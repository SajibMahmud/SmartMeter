﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Permission
    {
        //public Permission()
        //{
        //    this.RolePermissions = new HashSet<RolePermission>();
        //    this.UserPermissions = new HashSet<UserPermission>();
        //}

        public int PermissionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
    }
}