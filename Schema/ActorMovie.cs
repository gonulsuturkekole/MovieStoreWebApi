﻿using MovieStoreWebApi.Base;

namespace MovieStoreWebApi.Schema
{
    public class ActorMovie : BaseEntity
    {
        public int ActorId { get; set; }
        public Actor Actor { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
