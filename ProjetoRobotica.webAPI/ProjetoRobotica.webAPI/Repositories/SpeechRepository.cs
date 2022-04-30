using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using ProjetoRobotica.webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRobotica.webAPI.Repositories
{
    public class SpeechRepository : ISpeechRepository
    {

        public void TexttoSpeech(string texto)
        {
            var speechConfig = SpeechConfig.FromSubscription("355dfe15905a4ee990f74ddef984a703", "brazilsouth");
            speechConfig.SpeechSynthesisLanguage = "pt-BR";
            speechConfig.SpeechSynthesisVoiceName = "pt-BR-AntonioNeural";

            using var audioConfig = AudioConfig.FromWavFileOutput("C:\\Users\\User\\Desktop\\Projeto_Robotica\\ProjetoRobotica.webAPI\\ProjetoRobotica.webAPI\\StaticFiles\\file.wav");
            using var synthesizer = new SpeechSynthesizer(speechConfig, audioConfig);

            synthesizer.SpeakTextAsync(texto);
        }
    }
}