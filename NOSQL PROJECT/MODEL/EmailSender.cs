using System;
using System.Collections.Generic;
using System.Text;
using PostmarkDotNet;

namespace MODEL
{
    public class EmailSender
    {
        //method to send an email containing the new password
        public static void SendEmail(string email, string newPassword)
        {
            //create a new postmark message
            var message = new PostmarkMessage()
            {
                To = email,
                From = "683655@student.inholland.nl",
                TrackOpens = true,
                Subject = "NoDesk password change",
                TextBody = $"Your new NoDesk password is: {newPassword}",
                MessageStream = "outbound"
            };

            //send the message
            var client = new PostmarkClient("6dae1287-850e-48e3-b88d-e53c60314f16");
            client.SendMessageAsync(message);
        }
    }
}
