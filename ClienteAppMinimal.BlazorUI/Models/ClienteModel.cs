﻿namespace ClienteAppMinimal.BlazorUI.Models
{
    public class ClienteModel
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public DateTime DataHoraCriacao { get; set; }
    }
}
