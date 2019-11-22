using System;
using System.Data.Entity.Validation;
namespace Project.Core.Helper
{
    public class TryCatchAction
    {
        public static void TryCatch(Action action)
        {
            try
            {
                action();
            }
            catch (DbEntityValidationException deve)
            {
                foreach (var eve in deve.EntityValidationErrors)
                {
                    Console.WriteLine($"Girdi:{eve.Entry}");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine($"Hata Mesajı:{ve.ErrorMessage} Property Adı:{ve.PropertyName}");
                    }
                }
            }
        }
    }
}
