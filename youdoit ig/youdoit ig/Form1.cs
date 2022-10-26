using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youdoit_ig
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            
        }

        private void oogaBoogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ToastContentBuilder()
    .AddArgument("action", "viewConversation")
    .AddArgument("conversationId", 9813)
    .AddText("itsa me mario")
    .AddText("yay i worky")
    .AddButton(new ToastButton()
        .SetContent("Reply")
        .AddArgument("action", "reply")
        .SetBackgroundActivation())
    .Show();
        }
    }
}
