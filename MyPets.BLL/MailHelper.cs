﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Text;
using System.IO;

/// <summary>
///MailHelper 邮件操作类
/// </summary>
public class MailHelper
{
	public MailHelper()
	{
	
	}

    #region
    /// <summary>
    /// 发送邮件
    /// </summary>
    /// <param name="mailTo">要发送的邮箱</param>
    /// <param name="mailSubject">邮箱主题</param>
    /// <param name="mailContent">邮箱内容</param>
    /// <returns>返回发送邮箱的结果</returns>
    public static bool SendEmail(string mailTo,string mailSubject,string mailContent)
    {
        // 设置发送方的邮件信息,例如使用网易的smtp
        string smtpServer = "SMTP.jxnu.edu.cn"; //SMTP服务器
        string mailFrom = "shen@jxnu.edu.cn"; //登陆用户名
        string userPassword = "syq950529";//登陆密码

        // 邮件服务设置
        SmtpClient smtpClient=new SmtpClient();
        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
        smtpClient.Host = smtpServer; //指定SMTP服务器
        smtpClient.Credentials = new System.Net.NetworkCredential(mailFrom, userPassword);//用户名和密码

        // 发送邮件设置        
        MailMessage mailMessage = new MailMessage(mailFrom, mailTo); // 发送人和收件人
        mailMessage.Subject = mailSubject;//主题
        mailMessage.Body = mailContent;//内容
        mailMessage.BodyEncoding = Encoding.UTF8;//正文编码
        mailMessage.IsBodyHtml = true;//设置为HTML格式
        mailMessage.Priority = MailPriority.Low;//优先级

        try
        {
            smtpClient.Send(mailMessage); // 发送邮件
            return true;
        }
        catch (SmtpException ex)
        {
            return false;
        }
    }
    #endregion
}