using Coldairarrow.Util.Sockets;
using System;
using System.Text;

namespace Console_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cree un objeto cliente, la conexión predeterminada a la máquina 127.0.0.1, el puerto es 12345
            SocketClient client = new SocketClient(12345);

            //Vincular el evento de procesamiento después de recibir el mensaje enviado por el servidor
            client.HandleRecMsg = new Action<byte[], SocketClient>((bytes, theClient) =>
            {
                string msg = Encoding.UTF8.GetString(bytes);
                Console.WriteLine($"Mensaje recibido:{msg}");
            });

            //Vinculación de eventos de procesamiento después de enviar un mensaje al servidor
            client.HandleSendMsg = new Action<byte[], SocketClient>((bytes, theClient) =>
            {
                string msg = Encoding.UTF8.GetString(bytes);
                Console.WriteLine($"Envía un mensaje al servidor:{msg}");
            });

            //Cliente en ejecución
            client.StartClient();

            while (true)
            {
                Console.WriteLine("Enter: salga para cerrar el cliente, ingrese otros mensajes para enviar al servidor");
                string str = Console.ReadLine();
                if (str == "quit")
                {
                    client.Close();
                    break;
                }
                else
                {
                    client.Send(str);
                }
            }
        }
    }
}
