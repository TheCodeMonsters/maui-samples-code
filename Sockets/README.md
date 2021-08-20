# Sockets
Un marco de trabajo de sockets de C # muy útil
Cómo usarlo está aquí: http://www.cnblogs.com/coldairarrow/p/7501645.html

¿Cómo usarlo?
Clase de núcleo del marco:
SocketServer // Servidor de socket
SocketConnection // Objeto de conexión de socket, comunicación
bidireccional SocketClient // Cliente de socket

1, establecimiento de conexión
Servidor:
SocketServer server = new SocketServer (12345); // dirección de escucha predeterminada 0.0.0.0 puerto 12345 , la sobrecarga del constructor puede modificar
server.StartServer ();
cliente:
SocketClient client = new SocketClient (12345); // La dirección de conexión predeterminada es 127.0.0.1 puerto 12345, la sobrecarga del constructor puede modificar
client.StartClient ();

2, Mensaje
Servidor de envío y recepción : El
servidor mantiene principalmente una cola de conexión de cliente.Cada vez que un nuevo cliente se conecta al servidor, se agregará un nuevo objeto de conexión a la cola de conexión.
Por lo tanto, para que el servidor envíe un mensaje al cliente, primero debe encontrar el objeto de conexión que necesita enviar el mensaje.
Entonces, ¿cómo puede encontrar la conexión que necesita para enviar un mensaje?
Idea: cuando buscamos algo, definitivamente necesitamos las características de ciertas cosas. Por ejemplo, si queremos confirmar la identidad de una persona, solo necesitamos saber la identificación de la persona (sin contar las negras), entonces podemos fácilmente conocer la identidad de esta persona. De la misma manera, he abierto una propiedad personalizada Property a SocketConnection de antemano, su tipo es objeto, es decir, puede pasar una cadena o un objeto personalizado, y esta propiedad se puede usar como el símbolo de identidad de la conexión actual. Cuando la conexión tiene una marca de identidad, se puede consultar a través de expresiones Lambda (si no sabe cómo complementar los conceptos básicos usted mismo), el servidor llama al método GetConnectionList y pasa las condiciones de filtro para encontrar el IEnumerable elegible. también llame al método GetTheConnection.
Pase los criterios del filtro y busque un SocketConnection que cumpla con los criterios. El ejemplo de uso es el siguiente: var theConnection = server.GetTheConnection (x =>
{
var Id = (string) x.Property;
return Id == "Admin";
});

ver el código Es difícil, agregue lo básico.

Enviar un mensaje:
theConnection.Send ("Hello World!"); // El formato de codificación UTF-8 predeterminado se usa para enviar una cadena , y hay un método de sobrecarga, que no se explica en detalle.
Cliente:
Enviar un mensaje:
client.Send ("OK!"); // El formato de codificación UTF-8 predeterminado se usa para enviar la cadena, hay un método de sobrecarga, no se explica en detalle

Procesamiento de eventos: Después de que el
cliente se conecta al servidor, las dos partes deben comunicarse, es decir, enviar y recibir datos. Aquí solo hablaré de los eventos más utilizados

1. Disparo cuando un nuevo cliente se conecta al servidor (puedes elija dar los pases correspondientes de SocketConnection en la propiedad de identificación de identidad)
server.HandleNewClientConnected = new Action <SocketServer, SocketConnection> ((theServer, theCon) =>
{
theCon.Property = "Admin"; Cuando se usa, se ve obligado a rechazar (no entiendo, Baidu: polimorfismo)
Console.WriteLine ($ @ "Recuento de conexiones actuales: {theServer.GetConnectionCount ()}");
});

2. El servidor recibe el mensaje enviado por el cliente Trigger cuando
// bytes son los datos recibidos (matriz de bytes), el cliente es el correspondiente SocketConnection, el servidor es el objeto de servicio que mantiene el
servidor de conexión. HandleRecMsg = new Action <byte [], SocketConnection, SocketServer> ((bytes, cliente, el servidor) =>
{ string msg = Encoding.UTF8.GetString (bytes);
client.Send ($ "El servidor ha recibido el mensaje recibido: {msg}");
Console.WriteLine ($ "El mensaje recibido: {msg}");
});

3. Cuando el cliente recibe un mensaje enviado por el cliente, activa
client.HandleRecMsg = new Action <byte [], SocketClient> ((bytes, theClient) =>
{
string msg = Encoding.UTF8.GetString (bytes);
Console . WriteLine ($ "Mensaje recibido: {msg}");
});

Finalmente: hay muchas otras operaciones, consulte la interfaz externa de los tres tipos