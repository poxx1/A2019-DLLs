using System;
using Microsoft.Exchange.WebServices.Data;
using System.Linq;
using System.Threading;

namespace ExchangeEmail
{
    public class Email
    {
        #region Variables
        static TimeZoneInfo timeZoneInfo = TimeZoneInfo.Local.Id == "Pacific SA Standard Time" ? TimeZoneInfo.CreateCustomTimeZone("WorkAround TimeZoneInfo",
            TimeZoneInfo.Local.BaseUtcOffset, "WorkAround TimeZoneInfo", "WorkAround TimeZoneInfo") : TimeZoneInfo.Local;

        ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2013, timeZoneInfo);
        #endregion
        public string Leer(EmailMessage mensaje)
        {
            PropertySet properties = new PropertySet(BasePropertySet.FirstClassProperties);
            properties.RequestedBodyType = BodyType.Text;
            mensaje.Load(properties);

            var subject = mensaje.Subject;
            mensaje.Body.BodyType = BodyType.Text;
            var body = mensaje.Body.Text;

            DateTime date = mensaje.DateTimeReceived;

            var recipients = mensaje.ToRecipients;

            //Proceso la informacion del correo.
            return body;
        }
        public string Extraer()
        {
            ConectarExchange();

            var offset = 0;
            const int pageSize = 100;

            FindItemsResults<Item> result;
            do
            {
                Folder folder = Folder.Bind(service, WellKnownFolderName.Inbox);
                ItemView itemView = new ItemView(pageSize, offset);
                result = folder.FindItems(itemView);

                if (result.TotalCount > 0)
                {
                    //Significa que se encontraron correos;
                    foreach (var email in result)
                    {
                        EmailMessage message = EmailMessage.Bind(service, email.Id);
                        return Leer(message);
                    }
                }
                else
                //No se encontraron correos
                {
                    Thread.Sleep(1000);
                    return "Sin correos";
                }

                offset += pageSize;
            }
            while (result.MoreAvailable);

            if (result.TotalCount > 0)
            {
                //Termino con la revision de emails.
            }
            return "Fin";
        }
        public void Send()
        {
            service.UseDefaultCredentials = false;

            service.Credentials = new WebCredentials("elasticautomation@outlook.com", "Tsoft2020");
            service.Url = new Uri("https://outlook.office365.com/EWS/Exchange.asmx");

            try
            {
                var message = new EmailMessage(service)
                {
                    Subject = "Se resolvio el ticket!",
                    Body = "Se reinicio el servidor 192.168.1.35 con exito."
                };
                message.ToRecipients.Add("julian.lastra@tsoftlatam.com");
                message.Send();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
        public void ConectarExchange()
        {
            if (service.Credentials == null)
            {
                service.UseDefaultCredentials = false;
                service.Credentials = new WebCredentials("elasticautomation@outlook.com", "Tsoft2020");
                service.Url = new Uri("https://outlook.office365.com/EWS/Exchange.asmx");

                //Aca puedo llamar a Leer correos;
            }
        }
        public void MoverCorreo(EmailMessage message, string folder)
        {
            FolderView view = new FolderView(1000);
            view.PropertySet = new PropertySet(BasePropertySet.IdOnly);
            view.PropertySet.Add(FolderSchema.DisplayName);
            view.Traversal = FolderTraversal.Deep;

            FindFoldersResults results = service.FindFolders(new FolderId(WellKnownFolderName.Root, "usuario"), view);

            int cantidad = results.Count();

            foreach (Folder carpeta in results)
            {
                if (carpeta.DisplayName == folder)
                {
                    try
                    {
                        message.Move(carpeta.Id);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }
}
