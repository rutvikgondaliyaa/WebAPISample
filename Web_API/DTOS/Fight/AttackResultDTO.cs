﻿namespace Web_API.DTOS.Fight
{
    public class AttackResultDTO
    {
        public string Attacker { get; set; }
        public string Opponent { get; set; }
        public int AttackerHP { get; set; }
        public int OpponentHP{ get; set; }
        public int Damage{ get; set; }
    }
}
