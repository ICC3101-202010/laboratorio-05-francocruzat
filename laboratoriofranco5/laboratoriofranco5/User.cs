using System;
namespace laboratoriofranco5
{
    public class User
    {
        string Vc;
        //Creamos el delegate para el evento EmailVerified
        public delegate void VerifiedEmail(object source,EventArgs args);
        //declaramos evento
        public event VerifiedEmail EmailVerified;

        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                Console.WriteLine("Desea verificar su correo? Ingrese si o no");
                Vc = Console.ReadLine();
                if (Vc == "si")
                {
                    //mandamos la señal
                    EmailVerified(this, EventArgs.Empty);
                }
            }


        }
        public void OnEmailSent(object source, )



    }
}
