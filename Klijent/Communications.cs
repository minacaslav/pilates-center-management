using Common.Communication;
using Common.Domain;
using System.Diagnostics;
using System.Net.Sockets;

namespace Client
{
    public class Communication
    {

        private static Communication instance;
        public static Communication Instance => instance ??= new Communication();

        private Communication() { }

        private Socket socket;
        private JsonNetworkSerializer jsonSerializer;

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            jsonSerializer = new JsonNetworkSerializer(socket);
        }
        internal Response Login(Trener trener)
        {
            Request req = new Request
            {
                Argument = trener,
                Operation = Operation.PrijavaTrenera
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            response.Result = jsonSerializer.ReadType<Trener>(response.Result);
            return response;
        }
        public void Close()
        {
            try
            {
                jsonSerializer?.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Грешка при затварању serializer-а: {ex.Message}");
            }
            finally
            {
                try
                {
                    if (IsConnected())
                    {
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Грешка при затварању socket-а: {ex.Message}");
                }
            }
        }
        public bool IsConnected() => socket?.Connected == true;

        #region EvidencijaClanarine
        internal Response KreirajEvidencijaClanarine(EvidencijaClanarine evidencija)
        {
            Request req = new Request
            {
                Argument = evidencija,
                Operation = Operation.KreirajEvidencijuClanarine
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }
            //*
            response.Result = jsonSerializer.ReadType<EvidencijaClanarine>(response.Result);
            return response;
        }
        internal Response PretraziEvidencijaClanarine(EvidencijaClanarine kriterijum) //*
        {
            Request req = new Request
            {
                Argument = kriterijum,
                Operation = Operation.PretraziEvidencijeClanarine
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            response.Result = jsonSerializer.ReadType<List<EvidencijaClanarine>>(response.Result);
            return response;
        }
        internal Response PromeniEvidencijaClanarine(EvidencijaClanarine evidencija)
        {
            Request req = new Request
            {
                Argument = evidencija,
                Operation = Operation.PromeniEvidencijuClanarine
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            return response;
        }
        internal Response VratiListuEvidencijaClanarinePoEvidenciji(EvidencijaClanarine kriterijum)
        {
            Request req = new Request
            {
                Argument = kriterijum,
                Operation = Operation.VratiListuEvidencijaClanarineKriterijumEvidencija
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            response.Result = jsonSerializer.ReadType<List<EvidencijaClanarine>>(response.Result);
            return response;
        }
        internal Response VratiListuEvidencijaClanarinePoTreneru(Trener kriterijum)
        {
            Request req = new Request
            {
                Argument = kriterijum,
                Operation = Operation.VratiListuEvidencijaClanarineKriterijumTrener
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            response.Result = jsonSerializer.ReadType<List<EvidencijaClanarine>>(response.Result);
            return response;
        }
        internal Response VratiListuEvidencijaClanarinePoClanu(Clan kriterijum)
        {
            Request req = new Request
            {
                Argument = kriterijum,
                Operation = Operation.VratiListuEvidencijaClanarineKriterijumClan
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            response.Result = jsonSerializer.ReadType<List<EvidencijaClanarine>>(response.Result);
            return response;
        }
        internal Response VratiListuEvidencijaClanarinePoTipuClanarine(TipClanarine kriterijum)
        {
            Request req = new Request
            {
                Argument = kriterijum,
                Operation = Operation.VratiListuEvidencijaClanarineKriterijumTipClanarine
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            response.Result = jsonSerializer.ReadType<List<EvidencijaClanarine>>(response.Result);
            return response;
        }
        #endregion

        #region VratiListu
        internal Response VratiListuSviClan()
        {
            Request req = new Request
            {
                Operation = Operation.VratiListuSvihClanova
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            response.Result = jsonSerializer.ReadType<List<Clan>>(response.Result);
            return response;
        }
        internal Response VratiListuSviClanPoKriterijumu(Clan kriterijum)
        {
            Request req = new Request
            {
                Argument = kriterijum,
                Operation = Operation.VratiListuSvihClanova
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            response.Result = jsonSerializer.ReadType<List<Clan>>(response.Result);
            return response;
        }
        internal Response VratiListuSviTipClana()
        {
            Request req = new Request
            {
                Operation = Operation.VratiListuSvihTipClana
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            response.Result = jsonSerializer.ReadType<List<TipClana>>(response.Result);
            return response;
        }
        internal Response VratiListuSviTrener()
        {
            Request req = new Request
            {
                Operation = Operation.VratiListuSvihTrenera
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            response.Result = jsonSerializer.ReadType<List<Trener>>(response.Result);
            return response;
        }
        internal Response VratiListuSviTipClanarine()
        {
            Request req = new Request
            {
                Operation = Operation.VratiListuSvihTipClanarine
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            response.Result = jsonSerializer.ReadType<List<TipClanarine>>(response.Result);
            return response;
        }
        #endregion

        #region Clan
        internal Response KreirajClan(Clan clan)
        {
            Request req = new Request
            {
                Argument = clan,
                Operation = Operation.KreirajClana
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            response.Result = jsonSerializer.ReadType<Clan>(response.Result);
            return response;
        }
        internal Response PromeniClan(Clan clan)
        {
            Request req = new Request
            {
                Argument = clan,
                Operation = Operation.PromeniClana
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            return response;
        }
        internal Response ObrisiClan(Clan clan)
        {
            Request req = new Request
            {
                Argument = clan,
                Operation = Operation.ObrisiClana
            };
            jsonSerializer.Send(req);
            Response response = jsonSerializer.Receive<Response>();

            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }

            return response;
        }
        #endregion

        internal Response UbaciTrening(Trening trening)
        {
            Request request = new Request
            {
                Argument = trening,
                Operation = Operation.UbaciTrening
            };
            jsonSerializer.Send(request);

            Response response = jsonSerializer.Receive<Response>();
            if (response.ExceptionMessage != null)
            {
                throw new Exception(response.ExceptionMessage);
            }
            return response;
        }
    }
}