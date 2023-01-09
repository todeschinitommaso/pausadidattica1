using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pausadidattica1
{
    internal class volo
    {

        public string _codice;

        public int _posti; //100/200

        public int _prezzo; //9/20€

        private string _partenza;

        private string _destinazione;

        private DateTime _orario;

        private int _nprenotazioni = 0;

        public string CodiceVolo()
        {
            Random rnd = new Random();

            int let = rnd.Next(0, 26);
            char a = (char)('A' + let);
            char b = (char)('A' + let);

            char c = (char)('a' + let);
            char d = (char)('a' + let);
            char e = (char)('a' + let);

            int num = rnd.Next(0, 9);
            char f = (char)('0' + num);
            char g = (char)('0' + num);
            char h = (char)('0' + num);

            _codice = a.ToString() + b.ToString() + c.ToString() + d.ToString() + e.ToString() + f.ToString() + g.ToString() + h.ToString();

            return _codice;
        }

        public int NumPosti(int _posti)
        {
            Random rnd = new Random();
            _posti = rnd.Next(100, 200);

            return _posti;
        }

        public int Costo(int _prezzo)
        {
            Random rnd = new Random();
            _prezzo = rnd.Next(9, 20);

            return _prezzo;
        }

        public int EmissioneBiglietto(int _prezzo, int _nprenotazioni)
        {
            while(_nprenotazioni < _posti)
            {
                if(_nprenotazioni % 5 == 0 && _nprenotazioni != 0)
                {
                    int aggiunta = (5 * _prezzo) / 100;
                    _prezzo = _prezzo + aggiunta;
                }
            }
            return _nprenotazioni;
        }

        public string Codice
        {
            get
            {
                return _codice;
            }
            private set
            {
                if (value != null)
                    _codice = value;
                else
                    throw new Exception("Codice non valido");
            }
        }

        public int Posti
        {
            get
            {
                return _posti;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Posto non valido");
                else
                    _posti = value;
            }
        }

        public int Prezzo
        {
            get
            {
                return _prezzo;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Prezzo non valido");
                else
                    _prezzo = value;
            }
        }

        public string Partenza
        {
            get
            {
                return _partenza;
            }
            private set
            {
                if (value != null)
                    _partenza = value;
                else
                    throw new Exception("Partenza non valida");
            }
        }

        public string Destinazione
        {
            get
            {
                return _destinazione;
            }
            private set
            {
                if (value != null)
                    _destinazione = value;
                else
                    throw new Exception("Destinazione non valida");
            }
        }

        public DateTime Orario
        {
            get
            {
                return _orario;
            }
            set
            {
                if (value < DateTime.Now)
                    throw new Exception("Data non valida");
                else
                    _orario = value;
            }
        }

        public int Nprenotazioni
        {
            get
            {
                return _nprenotazioni;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Prenotazione non valida");
                else
                    _nprenotazioni = value;
            }
        }

        public volo(string codice, int posti, int prezzo, string partenza, string destinazione, DateTime orario, int nprenotazioni)
        {
            Codice = _codice;
            Posti = _posti;
            Prezzo = _prezzo;
            Partenza = _partenza;
            Destinazione = _destinazione;
            Orario = _orario;
            Nprenotazioni = _nprenotazioni;
        }

    }
}
