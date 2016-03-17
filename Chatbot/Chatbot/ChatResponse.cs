﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using AIMLbot;

namespace Chatbot
{
    class ChatResponse
    {
        Bot AimlBot;

        public ChatResponse()
        {
            AimlBot = new Bot();

            AimlBot.loadSettings();
            AimlBot.isAcceptingUserInput = false;
            AimlBot.loadAIMLFromFiles();
            AimlBot.isAcceptingUserInput = true;
        }

        public string getResponse(string input, User theUsr)
        {

            Request r = new Request(input, theUsr, AimlBot);
            Result res = AimlBot.Chat(r);

            return res.Output;
        }

        public Bot getBot()
        {
            return AimlBot;
        }
    }
}