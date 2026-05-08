using Common.Communication;
using Common.Domain;
using System.Diagnostics;
using System.Net.Sockets;

namespace Server
{
    public class ClientHandler
    {
        private readonly JsonNetworkSerializer jsonSerializer;
        private Socket socket;
        private readonly Server server;
        private List<EvidencijaClanarine> evidencije = [];

        public ClientHandler(Socket socket, Server server)
        {
            this.socket = socket;
            this.server = server;
            jsonSerializer = new JsonNetworkSerializer(socket);
        }

        public void HandleRequest()
        {
            try
            {
                while (true)
                {
                    if (!socket.Connected)
                        break;

                    Request req = jsonSerializer.Receive<Request>();

                    if (req == null)
                    {
                        Debug.WriteLine("Клијент је затворио конекцију.");
                        break;
                    }

                    Response r = ProcessRequest(req);
                    jsonSerializer.Send(r);
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine("Комуникација са клијентом је прекинута: " + ex.Message);
            }
            catch (IOException ex)
            {
                Debug.WriteLine("Комуникација са клијентом је прекинута: " + ex.Message);
            }
            finally
            {
                if (socket.Connected)
                {
                    socket.Close();
                }
                server.RemoveClient(this);
            }
        }

        private Response ProcessRequest(Request req)
        {
            Response r = new Response();

            if (req == null)
            {
                r.ExceptionMessage = "Дошло је до грешке приликом примања захтева.";
                return r;
            }

            try
            {
                switch (req.Operation)
                {
                    case Operation.PrijavaTrenera:
                        r.Result = Controller.Instance.Login(jsonSerializer.ReadType<Trener>(req.Argument));
                        break;

                    case Operation.KreirajEvidencijuClanarine:
                        r.Result = Controller.Instance.KreirajEvidencijaClanarine(jsonSerializer.ReadType<EvidencijaClanarine>(req.Argument));
                        break;

                    case Operation.PretraziEvidencijeClanarine:
                        r.Result = Controller.Instance.PretraziEvidencijaClanarine(jsonSerializer.ReadType<EvidencijaClanarine>(req.Argument));
                        break;

                    case Operation.PromeniEvidencijuClanarine:
                        Controller.Instance.PromeniEvidencijaClanarine(jsonSerializer.ReadType<EvidencijaClanarine>(req.Argument));
                        r.Result = true;
                        break;

                    case Operation.VratiListuEvidencijaClanarineKriterijumClan:
                        if (evidencije != null)
                            evidencije.Clear();

                        Controller.Instance.VratiListuEvidencijaClanarine(jsonSerializer.ReadType<Clan>(req.Argument), ref evidencije!);
                        r.Result = evidencije;
                        break;
                    case Operation.VratiListuEvidencijaClanarineKriterijumEvidencija:
                        if (evidencije != null)
                            evidencije.Clear();

                        Controller.Instance.VratiListuEvidencijaClanarine(jsonSerializer.ReadType<EvidencijaClanarine>(req.Argument), ref evidencije!);
                        r.Result = evidencije;
                        break;
                    case Operation.VratiListuEvidencijaClanarineKriterijumTipClanarine:
                        if (evidencije != null)
                            evidencije.Clear();

                        Controller.Instance.VratiListuEvidencijaClanarine(jsonSerializer.ReadType<TipClanarine>(req.Argument), ref evidencije!);
                        r.Result = evidencije;
                        break;
                    case Operation.VratiListuEvidencijaClanarineKriterijumTrener:
                        if (evidencije != null)
                            evidencije.Clear();

                        Controller.Instance.VratiListuEvidencijaClanarine(jsonSerializer.ReadType<Trener>(req.Argument), ref evidencije!);
                        r.Result = evidencije;
                        break;

                    case Operation.VratiListuSvihClanova:
                        r.Result = Controller.Instance.VratiListuSviClan(jsonSerializer.ReadType<Clan>(req.Argument));
                        break;

                    case Operation.VratiListuSvihTipClana:
                        r.Result = Controller.Instance.VratiListuSviTipClana();
                        break;

                    case Operation.VratiListuSvihTrenera:
                        r.Result = Controller.Instance.VratiListuSviTrener();
                        break;

                    case Operation.VratiListuSvihTipClanarine:
                        r.Result = Controller.Instance.VratiListuSviTipClanarine();
                        break;

                    case Operation.KreirajClana:
                        r.Result = Controller.Instance.KreirajClan(jsonSerializer.ReadType<Clan>(req.Argument));
                        break;

                    case Operation.PromeniClana:
                        Controller.Instance.PromeniClan(jsonSerializer.ReadType<Clan>(req.Argument));
                        r.Result = true;
                        break;

                    case Operation.ObrisiClana:
                        Controller.Instance.ObrisiClan(jsonSerializer.ReadType<Clan>(req.Argument));
                        r.Result = true;
                        break;

                    case Operation.UbaciTrening:
                        Controller.Instance.UbaciTrening(jsonSerializer.ReadType<Trening>(req.Argument));
                        break;
                    default:
                        throw new Exception($"Непозната операција: {req.Operation}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(r.ExceptionMessage);
                r.ExceptionMessage = ex.Message;
            }
            return r;
        }

        internal void CloseSocket() => socket.Close();
    }
}