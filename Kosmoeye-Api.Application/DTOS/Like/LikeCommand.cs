﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosmoeye_Api.Application.DTOS.Like
{
    public class LikeCommand
    {
        public Guid UserId { get; set; }
        public Guid ArtworkId { get; set; }
    }

}
