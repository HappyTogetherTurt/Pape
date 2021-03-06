﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pape
{
    public static class Lists
    {

        private static string[] igcseList =
        {
                               "Accounting (0452)",
                               "Afrikaans - First Language (0512)",
                               "Afrikaans - Second Language (0548)",
                               "Agriculture (0600)",
                               "Arabic - First Language (0508)",
                               "Arabic - Foreign Language (0544)",
                               "Art and Design (0400)",
                               "Art and Design (9-1) (0989)",
                               "Bahasa Indonesia (0538)",
                               "Bangladesh Studies (0449)",
                               "Biology (0610)",
                               "Biology (9-1) (0970)",
                               "Biology (US) (0438)",
                               "Business Studies (0450)",
                               "Chemistry (0620)",
                               "Chemistry (9-1) (0971)",
                               "Chemistry (US) (0439)",
                               "Child Development (0637)",
                               "Chinese (Mandarin) - Foreign Language (0547)",
                               "Chinese - First Language (0509)",
                               "Chinese - Second Language (0523)",
                               "Computer Science (0478)",
                               "Computer Studies (0420)",
                               "Czech - First Language (0514)",
                               "Design and Technology (0445)",
                               "Design and Technology (9-1) (0979)",
                               "Development Studies (0453)",
                               "Drama (0411)",
                               "Dutch - First Language (0503)",
                               "Dutch - Foreign Language (0515)",
                               "Economics (0455)",
                               "English - First Language (0500)",
                               "English - First Language (0990)",
                               "English - First Language (9–1) (UK only) (0627)",
                               "English - First Language (UK) (0522)",
                               "English - First Language (US) (0524)",
                               "English - Literature (9-1) (UK only) (0477)",
                               "English - Literature in English (9-1) (0992)",
                               "English as a Second Language (Count-in speaking) (0511)",
                               "English as a Second Language (Count-in Speaking) (9-1) (0991)",
                               "English as a Second Language (Speaking endorsement) (0510)",
                               "English – Literature (English) (0486)",
                               "English – Literature (US) (0427)",
                               "English – Literature in English (0475)",
                               "Enterprise (0454)",
                               "Environmental Management (0680)",
                               "Food and Nutrition (0648)",
                               "French (9-1) (7156)",
                               "French - First Language (0501)",
                               "French - Foreign Language (0520)",
                               "Geography (0460)",
                               "Geography (9-1) (0976)",
                               "German - First Language (0505)",
                               "German - Foreign Language (0525)",
                               "Global Perspectives (0457)",
                               "Greek - Foreign Language (0543)",
                               "Hindi as a Second Language (0549)",
                               "History (0470)",
                               "History (9-1) (0977)",
                               "History (US) (0416)",
                               "History - American (US) (0409)",
                               "India Studies (0447)",
                               "Indonesian - Foreign Language (0545)",
                               "Information and Communication Technology (0417)",
                               "IsiZulu as a Second Language (0531)",
                               "Islamiyat (0493)",
                               "Italian (9-1) (7164)",
                               "Italian - Foreign Language (0535)",
                               "Japanese - First Language (0507)",
                               "Japanese - Foreign Language (0519)",
                               "Kazakh as a Second Language (0532)",
                               "Korean (First Language) (0521)",
                               "Latin (0480)",
                               "Malay - Foreign Language (0546)",
                               "Mathematics (0580)",
                               "Mathematics (9-1) (0980)",
                               "Mathematics (9-1) (UK only) (0626)",
                               "Mathematics (US) (0444)",
                               "Mathematics - Additional (0606)",
                               "Mathematics - Additional (US) (0459)",
                               "Mathematics - International (0607)",
                               "Music (0410)",
                               "Pakistan Studies (0448)",
                               "Physical Education (0413)",
                               "Physical Education (9-1) (0995)",
                               "Physical Science (0652)",
                               "Physics (0625)",
                               "Physics (9-1) (0972)",
                               "Portuguese - First Language (0504)",
                               "Portuguese - Foreign Language (0540)",
                               "Religious Studies (0490)",
                               "Russian - First Language (0516)",
                               "Sanskrit (0499)",
                               "Science - Combined (0653)",
                               "Sciences - Co-ordinated (9-1) (0973)",
                               "Sciences - Co-ordinated (Double) (0654)",
                               "Sociology (0495)",
                               "Spanish (9-1) (7160)",
                               "Spanish - First Language (0502)",
                               "Spanish - Foreign Language (0530)",
                               "Spanish - Literature (0488)",
                               "Thai - First Language (0518)",
                               "Travel and Tourism (0471)",
                               "Turkish - First Language (0513)",
                               "Urdu as a Second Language (0539)",
                               "World Literature (0408)"
    };      //fields
        private static string[] asList =
            {
    "Accounting (9706)",       //addyear
    "Afrikaans (9679)",
    "Afrikaans - First Language (AS Level only) (8779)",
    "Afrikaans - Language (AS Level only) (8679)",
    "Applied Information and Communication Technology (9713)",
    "Arabic (9680)",
    "Arabic - Language (AS Level only) (8680)",
    "Art and Design (9479)",
    "Art and Design (9704)",
    "Biology (9700)",       //addyear
    "Business (9609)",
    "Chemistry (9701)",
    "Chinese (A Level only) (9715)",
    "Chinese - Language (AS Level only) (8681)",
    "Classical Studies (9274)",
    "Computer Science (9608)",
    "Computer Science (9618)",
    "Computing (9691)",
    "Design and Technology (9705)",
    "Design and Textiles (9631)",
    "Digital Media and Design (9481)",
    "Divinity (9011)",
    "Divinity (AS Level only) (8041)",
    "Economics (9708)",
    "English - Language (9093)",
    "English - Language and Literature (AS Level only) (8695)",
    "English - Literature (9695)",
    "Environmental Management (AS only) (8291)",
    "Food Studies (9336)",
    "French (A Level only) (9716)",
    "French - Language (AS Level only) (8682)",
    "French - Literature (AS Level only) (8670)",
    "General Paper (AS Level only) (8021)",
    "General Paper 8001 (AS Level only) (8001)",
    "General Paper 8004 (AS Level only) (8004)",
    "Geography (9696)",
    "German (A Level only) (9717)",
    "German - Language (AS Level only) (8683)",
    "Global Perspectives (AS Level only) (8987)",
    "Global Perspectives and Research (9239)",
    "Hindi (A Level only) (9687)",
    "Hindi - Language (AS Level only) (8687)",
    "Hindi - Literature (AS Level only) (8675)",
    "Hinduism (9014)",
    "Hinduism (AS level only) (8058)",
    "History (9389)",
    "History (9489)",
    "Information Technology (9626)",
    "Islamic Studies (9013)",
    "Islamic Studies (9488)",
    "Islamic Studies (AS Level only) (8053)",
    "Japanese Language (AS Level only) (8281)",
    "Law (9084)",
    "Marathi (A Level only) (9688)",
    "Marathi - Language (AS Level only) (8688)",
    "Marine Science (9693)",
    "Mathematics (9709)",       //addyear
    "Mathematics - Further (9231)",
    "Media Studies (9607)",
    "Music (9483)",
    "Music (9703)",
    "Music (AS Level only) (8663)",
    "Nepal Studies (AS Level only) (8024)",
    "Physical Education (9396)",
    "Physics (9702)",
    "Portuguese (A Level only) (9718)",
    "Portuguese - Language (AS Level only) (8684)",
    "Portuguese - Literature (AS Level only) (8672)",
    "Psychology (9698)",
    "Psychology (9990)",
    "Sociology (9699)",
    "Spanish (A Level only) (9719)",
    "Spanish - First Language (AS Level only) (8665)",
    "Spanish - Language (AS Level only) (8685)",
    "Spanish - Literature (AS Level only) (8673)",
    "Tamil (9689)",
    "Tamil - Language (AS Level only) (8689)",
    "Telugu (A Level only) (9690)",
    "Telugu - Language (AS Level only) (8690)",
    "Thinking Skills (9694)",
    "Travel and Tourism (9395)",
    "Urdu (A Level only) (9676)",
    "Urdu - Language (AS Level only) (8686)",
    "Urdu - Pakistan only (A Level only) (9686)",

};
        private static string[] gceSessions = { 
            "s", "w", "m"};
        private static string[] xtremeSessions = { 
            "s", "w", "y" };

        public static string[] IgcseList 
        {
            get { return igcseList; }
            set {;}
        }       //properties
        public static string[] AsList
        {
            get { return asList; }
            set {;}
        }
        public static string[] GceSessions
        {
            get { return gceSessions; }
            set {;}
        }
        public static string[] XtremeSessions
        {
            get { return xtremeSessions; }
            set {;}
        }
    }
}
