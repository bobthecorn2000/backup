using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Diagnostics;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Collections;

namespace ConsoleApp2
{
    internal class Program
    {
        protected void OOnLaunchedOrActivated(IActivatedEventArgs e)
        {
            // Handle notification activation
            if (e is ToastNotificationActivatedEventArgs toastActivationArgs)
            {
                // Obtain the arguments from the notification
                ToastArguments args = ToastArguments.Parse(toastActivationArgs.Argument);

                // Obtain any user input (text boxes, menu selections) from the notification
                ValueSet userInput = toastActivationArgs.UserInput;

                // TODO: Show the corresponding content
                Process.Start("SlideToShutDown.exe");

            }
        }
        static void Main(string[] args)
        {

            
                new ToastContentBuilder()
        .AddArgument("action", "viewConversation")
        .AddArgument("conversationId", 9813)
        .AddText("Rainbow Dash")
        .AddInputTextBox("tbReply", placeHolderContent: "Type a response")
        
         .AddAppLogoOverride(new Uri("C:\\Users\\tforsgren\\Downloads\\rain.jpg"), ToastGenericAppLogoCrop.Circle)
        .AddText("hello")
        .Show();

            
        }

    }
}
