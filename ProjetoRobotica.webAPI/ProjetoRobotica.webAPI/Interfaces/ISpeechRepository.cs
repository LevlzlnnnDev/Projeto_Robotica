using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRobotica.webAPI.Interfaces
{
    public interface ISpeechRepository
    {
        public void TexttoSpeech(string texto);
    }
}
