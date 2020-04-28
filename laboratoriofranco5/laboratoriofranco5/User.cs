using System;
namespace laboratoriofranco5
{
    public class User
    {
        string Verificar;

        //Creamos el delegate para el evento EmailVerified
        public delegate void VerifiedEmail(object source,EventArgs args);
        //declaramos evento
        public event VerifiedEmail EmailVerified;

        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, EventArgs.Empty);
            }

        }
        public void OnEmailSent(object source, EventArgs args)
        {
            Console.Write("Desea verificar el correo, responda si o no");
            Verificar = Console.ReadLine();
            if (Verificar == "si")
            {
                OnEmailVerified();
            }

            else
            {
                Console.WriteLine("No problem");
            }

        }



    }
}
