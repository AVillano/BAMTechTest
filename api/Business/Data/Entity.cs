﻿namespace StargateAPI.Business.Data
{
    public abstract class Entity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
