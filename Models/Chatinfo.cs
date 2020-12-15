using System;
namespace chatbot.Models
{
    public partial class Chatinfo
    {
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        private int? _WarnsQuantity;
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        private string _Welcome;
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        private string _Rules;
        public long Id { get; set; }
        public int? WarnsQuantity
        {
            get
            {
                if (!_WarnsQuantity.HasValue)
                {
                    return 5;
                }
                return _WarnsQuantity;
            }
            set => _WarnsQuantity = value.GetValueOrDefault();
        }
        public string Welcome
        {
            get
            {
                if (_Welcome == null)
                {
                    return "Добро пожаловать, {firstName}!";
                }
                return _Welcome;
            }
            set => _Welcome = value;
        }
        public string Rules
        {
            get
            {
                if (_Rules == null)
                {
                    return "Правила не установлены!";
                }
                return _Rules;
            }
            set => _Rules = value;
        }
        public string DisabledCommands { get; set; }
    }
}
