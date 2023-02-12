using System;
using System.Globalization;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;
using APP_API.Model;

namespace APP_API.Helpers
{
    public class CommonMethod
    {
        public static DateTime? stringToDate(string strDate)
        {
            try
            {
                DateTime? result = DateTime.ParseExact(strDate, "yyyyMMdd", CultureInfo.InvariantCulture);
                return result;
            }
            catch
            {
                return null;
            }
        }

        public static DateTime? stringToDate(string strDate, string strTime)
        {
            try
            {
                DateTime? result = DateTime.ParseExact(strDate + " " + strTime, "yyyyMMdd HHmm", CultureInfo.InvariantCulture);
                return result;
            }
            catch
            {
                return null;
            }
        }

        public static decimal DateToNumeric(DateTime _prmDate)
        {
            string _day = String.Empty, _month = String.Empty, _year = String.Empty;
            string _strDate = String.Empty;

            _day = _prmDate.ToString("dd").Trim();
            _month = _prmDate.ToString("MM").Trim();
            _year = _prmDate.ToString("yyyy").Trim();

            _strDate = _year + _month + _day;

            return Convert.ToDecimal(_strDate);
        }

        public static decimal DateToNumericNullable(DateTime? _prmDate)
        {
            string _day = String.Empty, _month = String.Empty, _year = String.Empty;
            string _strDate = String.Empty;

            _day = _prmDate?.ToString("dd").Trim();
            _month = _prmDate?.ToString("MM").Trim();
            _year = _prmDate?.ToString("yyyy").Trim();

            _strDate = _year + _month + _day;

            return Convert.ToDecimal(_strDate);
        }

        public static DateTime NumericToDateTime(decimal _prmDate, decimal _prmTime)
        {
            if (_prmDate != 0)
            {
                string strDate = Convert.ToString(_prmDate);

                int iYear = Convert.ToInt32(strDate.Substring(0, 4));
                int iMonth = Convert.ToInt32(strDate.Substring(4, 2));
                int iDay = Convert.ToInt32(strDate.Substring(6, 2));

                string strTime = "000000";
                if (_prmTime != 0)
                {
                    strTime = strTime + _prmTime.ToString();
                    strTime = strTime.Substring(strTime.Length - 6, 6);
                }

                int iHour = Convert.ToInt32(strTime.Substring(0, 2));
                int iMin = Convert.ToInt32(strTime.Substring(2, 2));
                int iSec = Convert.ToInt32(strTime.Substring(4, 2));

                DateTime _date;

                _date = new DateTime(iYear, iMonth, iDay, iHour, iMin, iSec);

                return _date;
            }
            else
            {
                return DateTime.Now;
            }
        }
        public static string NumericToDateString(decimal _prmDate)
        {
            if (_prmDate != 0)
            {
                string strDate = Convert.ToString(_prmDate);

                int iYear = Convert.ToInt32(strDate.Substring(0, 4));
                int iMonth = Convert.ToInt32(strDate.Substring(4, 2));
                int iDay = Convert.ToInt32(strDate.Substring(6, 2));

                DateTime _date;

                _date = new DateTime(iYear, iMonth, iDay);

                return _date.ToString("dd/MM/yyyy").Trim();
            }
            else
            {
                return String.Empty;
            }
        }

        public static DateTime NumericToDate(decimal _prmDate)
        {
            if (_prmDate != 0)
            {
                string strDate = Convert.ToString(_prmDate);

                int iYear = Convert.ToInt32(strDate.Substring(0, 4));
                int iMonth = Convert.ToInt32(strDate.Substring(4, 2));
                int iDay = Convert.ToInt32(strDate.Substring(6, 2));

                DateTime _date;

                _date = new DateTime(iYear, iMonth, iDay);

                return _date;
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        public static DateTime NumericToDateAndTime(decimal _prmDate, decimal _prmTime)
        {
            if (_prmDate != 0 && _prmTime != 0)
            {
                DateTime _date;
                string strDate = Convert.ToString(_prmDate);

                int iYear = Convert.ToInt32(strDate.Substring(0, 4));
                int iMonth = Convert.ToInt32(strDate.Substring(4, 2));
                int iDay = Convert.ToInt32(strDate.Substring(6, 2));

                string strTime = string.Empty;

                strTime = "000000" + _prmTime.ToString();
                strTime = strTime.Substring(strTime.Length - 6, 6);

                int iHour = Convert.ToInt32(strTime.Substring(0, 2));
                int iMinute = Convert.ToInt32(strTime.Substring(2, 2));
                int iSecond = Convert.ToInt32(strTime.Substring(4, 2));

                _date = new DateTime(iYear, iMonth, iDay, iHour, iMinute, iSecond);

                return _date;
            }
            else if (_prmDate != 0 && _prmTime == 0)
            {
                DateTime _date;
                string strDate = Convert.ToString(_prmDate);

                int iYear = Convert.ToInt32(strDate.Substring(0, 4));
                int iMonth = Convert.ToInt32(strDate.Substring(4, 2));
                int iDay = Convert.ToInt32(strDate.Substring(6, 2));

                string strTime = string.Empty;

                strTime = "000000";
                strTime = strTime.Substring(strTime.Length - 6, 6);

                int iHour = Convert.ToInt32(strTime.Substring(0, 2));
                int iMinute = Convert.ToInt32(strTime.Substring(2, 2));
                int iSecond = Convert.ToInt32(strTime.Substring(4, 2));

                _date = new DateTime(iYear, iMonth, iDay, iHour, iMinute, iSecond);

                return _date;
            }
            else
            {
                return DateTime.Today;
            }
        }


        public static decimal TimeToNumeric(DateTime _prmDate)
        {
            string _hour = String.Empty, _minute = String.Empty, _second = String.Empty;
            string _strTime = String.Empty;

            _hour = _prmDate.ToString("HH").Trim();
            _minute = _prmDate.ToString("mm").Trim();
            _second = _prmDate.ToString("ss").Trim();

            _strTime = _hour + _minute + _second;

            return Convert.ToDecimal(_strTime);
        }

        public static string NumericToTimeString(decimal _prmTime)
        {
            string strTime = string.Empty;

            strTime = "000000" + _prmTime.ToString();
            strTime = strTime.Substring(strTime.Length - 6, 6);

            string strHour = strTime.Substring(0, 2);
            string strMinute = strTime.Substring(2, 2);
            string strSecond = strTime.Substring(4, 2);

            strTime = strHour + ":" + strMinute + ":" + strSecond;

            return strTime;
        }

        public static decimal NumericTimeGetHour(decimal _prmTime)
        {
            string strTime = string.Empty;

            strTime = "000000" + _prmTime.ToString();
            strTime = strTime.Substring(strTime.Length - 6, 6);

            string strHour = strTime.Substring(0, 2);

            strTime = strHour + "0000";

            return Convert.ToDecimal(strTime);
        }

        public static string DecimalToTimeString(decimal _prmTime)
        {
            string strTime = string.Empty;

            if (_prmTime != 0)
            {
                strTime = "000000" + _prmTime.ToString();
                strTime = strTime.Substring(strTime.Length - 6, 6);

                string strHour = strTime.Substring(0, 2);
                string strMinute = strTime.Substring(2, 2);

                strTime = strHour + ":" + strMinute;
            }

            return strTime;
        }

        public static string SendMail(string[] msgTo, string msgFrom, string msgSbj,
                                    string msgBody, string[] msgCC, string smtpHost, int smtpPort)
        {
            MailMessage mailMessage = new MailMessage();
            string smtpServer = smtpHost;

            try
            {
                if (msgTo != null)
                {
                    foreach (var item in msgTo)
                    {
                        mailMessage.To.Add(new MailAddress(item.Trim()));
                    }
                }
                mailMessage.From = new MailAddress(msgFrom.Trim());
                mailMessage.Subject = msgSbj;
                mailMessage.Body = msgBody;
                mailMessage.IsBodyHtml = false;
                mailMessage.Priority = MailPriority.High;

                if (msgCC != null)
                {
                    foreach (var item in msgCC)
                    {
                        mailMessage.CC.Add(new MailAddress(item.Trim()));
                    }
                }

                mailMessage.Bcc.Add("muchamad.regananda@agc.com");

                SmtpClient smtp = new SmtpClient(smtpServer, smtpPort);
                smtp.UseDefaultCredentials = true;
                smtp.Send(mailMessage);

                return String.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string SendMailHtml(string[] msgTo, string msgFrom, string msgSbj,
                                    string msgBody, string[] msgCC, string smtpHost, int smtpPort)
        {
            MailMessage mailMessage = new MailMessage();
            string smtpServer = smtpHost;

            try
            {
                if (msgTo != null)
                {
                    foreach (var item in msgTo)
                    {
                        mailMessage.To.Add(new MailAddress(item.Trim()));
                    }
                }
                mailMessage.From = new MailAddress(msgFrom.Trim());
                mailMessage.Subject = msgSbj;
                mailMessage.Body = msgBody;
                mailMessage.IsBodyHtml = true;
                mailMessage.Priority = MailPriority.High;

                if (msgCC != null)
                {
                    foreach (var item in msgCC)
                    {
                        mailMessage.CC.Add(new MailAddress(item.Trim()));
                    }
                }

                mailMessage.Bcc.Add("muchamad.regananda@agc.com");

                SmtpClient smtp = new SmtpClient(smtpServer, smtpPort);
                smtp.UseDefaultCredentials = true;
                smtp.Send(mailMessage);

                return String.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string QtyFormat(decimal _prmQty)
        {
            string strQty = string.Empty;

            if (_prmQty != 0)
            {
                string[] result = _prmQty.ToString().Split('.');
                strQty = result[0];
            }
            else
            {
                strQty = _prmQty.ToString();
            }

            return strQty;
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
                return true;
            }
        }
        public static string GetBrno
        {
            get { return "CKP"; }
        }
        public static string GetCono
        {
            get { return "AMG"; }
        }
        public static DateTime JakartaTimeZone(DateTime _prmDate)
        {
            TimeZoneInfo timeInfo = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            DateTime estDt = TimeZoneInfo.ConvertTimeFromUtc(_prmDate, timeInfo);
            return estDt;
        }
        #region ZVAR

        #endregion

        #region Document Status
        public static string DocumentStatus(string dcst)
        {
            switch (dcst)
            {
                case "A":
                    return "Active";
                case "AV":
                    return "Approved";
                case "C":
                    return "Close";
                case "D":
                    return "Draft";
                case "E":
                    return "Cancel";
                case "O":
                    return "Open";
                case "RJ":
                    return "Reject";
                case "V":
                    return "Void";
                case "WA":
                    return "Wait Approve";
                case "WV":
                    return "Wait Void";
                default:
                    return string.Empty;
            }
        }

        public static string DocumentStatusDraft
        {
            get { return "D"; }
        }

        public static string DocumentStatusCompleted
        {
            get { return "C"; }
        }

        public static string DocumentStatusCancel
        {
            get { return "E"; }
        }

        public static string DocumentStatusInProgress
        {
            get { return "I"; }
        }

        public static string DocumentStatusApproved
        {
            get { return "AV"; }
        }

        public static string DocumentStatusWaitApproved
        {
            get { return "WA"; }
        }

        public static string DocumentStatusReject
        {
            get { return "RJ"; }
        }

        public static string DocumentStatusActive
        {
            get { return "A"; }
        }

        public static string DocumentStatusVoid
        {
            get { return "V"; }
        }
        public static string DocumentStatusOpen
        {
            get { return "O"; }
        }
        #endregion

        #region Record Status
        public static decimal RecordStatusActive
        {
            get { return 1; }
        }

        public static decimal RecordStatusInactive
        {
            get { return 0; }
        }
        #endregion

        public static string OrderStatusFinish
        {
            get { return "F"; }
        }

        public static string OrderStatusOutstanding
        {
            get { return "O"; }
        }

        public static string OrderStatusComplete
        {
            get { return "C"; }
        }

        public static string LineProcessStart
        {
            get { return "SR"; }
        }

        public static string LineProcessStop
        {
            get { return "ST"; }
        }

        public static string StatDraft
        {
            get { return "10"; }
        }

        public static string StatOpen
        {
            get { return "20"; }
        }

        public static string StatFinish
        {
            get { return "30"; }
        }

        public static string SystWaiting
        {
            get { return "10"; }
        }

        public static string SystProcess
        {
            get { return "50"; }
        }

        public static string SystTransfer
        {
            get { return "30"; }
        }

        public static class Predicates
        {
            public static bool IsNull<T>(T value) where T : class
            {
                return value == null;
            }

            public static bool IsNotNull<T>(T value) where T : class
            {
                return value != null;
            }

            public static bool IsNull<T>(T? nullableValue) where T : struct
            {
                return !nullableValue.HasValue;
            }

            public static bool IsNotNull<T>(T? nullableValue) where T : struct
            {
                return nullableValue.HasValue;
            }

            public static bool HasValue<T>(T? nullableValue) where T : struct
            {
                return nullableValue.HasValue;
            }

            public static bool HasNoValue<T>(T? nullableValue) where T : struct
            {
                return !nullableValue.HasValue;
            }
        }

    }
}