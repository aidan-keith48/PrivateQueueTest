using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;
using static J3QQ4.Emoji;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PrivateQueueTest
{
    public partial class Form1 : Form
    {
        private MessageQueue myMessageQueue = new MessageQueue();

        int UserID = 1;
        public Form1()
        {
            InitializeComponent();
            this.myMessageQueue.Path = @".\private$\NewQueue" + this.UserID;
            this.myMessageQueue.Formatter = new XmlMessageFormatter(
            new Type[] { typeof(string) });
        }

        private void SendQueueDataBtn_Click(object sender, EventArgs e)
        {
            if (MessageQueue.Exists(this.myMessageQueue.Path))
            {
                this.SendData2Queue();
            }
            else
            {
                MessageQueue.Create(this.myMessageQueue.Path);
                this.SendData2Queue();
            }
        }

        //----------------------------------------------------------------------------------

        public void SendData2Queue()
        {
            try
            {
                this.myMessageQueue.Send(this.messageTxt.Text.Trim() + J3QQ4.Emoji.Alien + "\r\n" +
                    DateTime.Now.ToString());
                this.myMessageQueue.Close();
                this.Text = "Message Count:" + this.Count(this.myMessageQueue);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.myMessageQueue.Close();
            }
        }

        //----------------------------------------------------------------------------------

        public int Count(MessageQueue queue)
        {
            int count = 0;
            var emunerator = queue.GetMessageEnumerator();

            while (emunerator.MoveNext())
            {
                count++;
            }

            this.Text = "Total Messages in Queue" + count;
            return count;
        }

        private void readMsgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageQueue.Exists(this.myMessageQueue.Path))
                {
                    if (this.Count(this.myMessageQueue) > 0)
                    {
                        var myMessage = this.myMessageQueue.Receive();
                        this.getMessageTxt.Text = myMessage.Body.ToString();
                        return;
                    }
                }
                this.Count(this.myMessageQueue);
                MessageBox.Show("No Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //----------------------------------------------------------------------------------

    }
}
