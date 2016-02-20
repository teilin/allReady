﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllReady.Areas.Admin.Features.Users
{
    public class DeleteUserCommand : IAsyncRequest
    {
        public string UserId { get; set; }
    }
}
