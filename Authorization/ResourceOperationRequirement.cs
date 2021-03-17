using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Authorization
{
    public class ResourceOperationRequirement : IAuthorizationRequirement
    {
        public enum ResourceOperation
        {
            Create,
            Read,
            Update,
            Delete
        }

        public ResourceOperation _resourceOperation { get; }

        public ResourceOperationRequirement(ResourceOperation resourceOperation)
        {
            _resourceOperation = resourceOperation;
        }
    }
}
