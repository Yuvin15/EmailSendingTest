﻿using System;
using System.Net.Mail;

namespace EmailSendApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MailMessage mm = new MailMessage();
            SmtpClient sc = new SmtpClient("smtp.gmail.com");
            mm.From = new MailAddress("yuvinpadayachee@gmail.com");
            mm.To.Add("yuvinpadayachee@gmail.com");
            mm.Subject = "Test";
            mm.Body = "This is a test";
            sc.EnableSsl = true;
            sc.Port = 587;
            sc.Credentials = new System.Net.NetworkCredential("yuvinpadayachee@gmail.com", "hxhj zbyo sktr watq"); 
            

            try
            {
                sc.Send(mm);
                Console.WriteLine("Email has been sent.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
