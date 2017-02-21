using System;
using System.IO;
using System.Net;
using System.Text;
using Atom.Core;
using Atom.Core.Collections;
using System.Linq;

namespace Furst_Alpha_2._0.HelperClasses
{
    public class HelperPrograms
    {
        private static readonly Uri _gmailServerUri = new Uri("https://mail.google.com/mail/feed/atom");

        private static void Main(string[] args)
        {

            string username = "furstemailtest@gmail.com";

            string password = "321success";

            ReadGMailEmail(username, password);
        }

        private static void ReadGMailEmail(string username, string password)
        {
            WebRequest webRequestGetUrl;
            try
            {
                // Create a new web-request instance
                webRequestGetUrl = WebRequest.Create(_gmailServerUri);

                byte[] bytes = Encoding.ASCII.GetBytes(username + ":" + password);

                // Add the headers for basic authentication.
                webRequestGetUrl.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(bytes));

                // Get the response feed
                Stream feedStream = webRequestGetUrl.GetResponse().GetResponseStream();

                // Load Feed into Atom DLL
                AtomFeed gmailFeed = AtomFeed.Load(feedStream);
                AtomEntryCollection entries = gmailFeed.Entries;


                Console.Clear();


                if (entries.Count > 0)
                {
                    //Console.WriteLine(string.Format("Found {0} email(s)", entries.Count));
                    // Console.WriteLine(Environment.NewLine);

                    for (int i = 0; i < 1; i++)
                    {
                        AtomEntry email = entries[i];
                        String[] test = email.Summary.Content.Split();
                        switch (email.Title.Content)
                        {
                            case "in":
                                Console.WriteLine("Items will be checked in");

                                foreach (String x in test)
                                {
                                    if (x.Length == 10 && x.All(char.IsDigit))
                                    {
                                        Console.WriteLine(x);
                                    }
                                }
                                break;
                            case "out":
                                Console.WriteLine("Items will be checked out");
                                foreach (String x in test)
                                {
                                    if (x.Length == 10 && x.All(char.IsDigit))
                                    {
                                        Console.WriteLine(x);
                                    }
                                }
                                break;
                            default:
                                pushNotification(email.Author.Email, "Resend", email.Title.Content + " Is an invalid command. Please Resend \n" + email.Summary.Content);
                                break;
                        }
                    }
                }
                Console.WriteLine("Hit 'Enter' to exit");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
            }
        }

        public static void pushNotification(String recipient, String subject, String message)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.Subject = subject;
            //We can rename this later based on how we want this sent
            msg.From = new System.Net.Mail.MailAddress("furstemailtest@gmail.com");
            //Change this to the users email in the account
            msg.To.Add(new System.Net.Mail.MailAddress(recipient));
            msg.Body = message;

            System.Net.Mail.SmtpClient smpt = new System.Net.Mail.SmtpClient();
            smpt.Host = "smtp.gmail.com";
            smpt.Port = 587;
            smpt.EnableSsl = true;
            smpt.Credentials = new System.Net.NetworkCredential("furstemailtest@gmail.com", "321success");
            smpt.Send(msg);
        }

    }
}