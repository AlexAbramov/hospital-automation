using System;
using System.Collections.Generic;
using System.Text;
using Geomethod.Data;

namespace HospitalDepartment
{
    public class UserInfo
    {
        #region Fields
        User user;
        Role role;
        Watching watching;
        #endregion

        public UserInfo() { }

        #region Properties
        public int UserId { get { return user == null ? 0 : user.Id; } }
        public string UserName { get { return user == null ? "?" : user.name; } }
        public Role Role { get { return role; } }
        public bool HasWatching { get { return role != null && role.watchingGroupId != 0; } }
        public Watching Watching { get { return watching; } }
        public bool HasPermission(PermissionId p) { return user == null ? false : role.HasPermission(p) || user.HasPermission(p); }
        #endregion

        #region Methods
        public bool Login(GmConnection conn, string login, string psw)
        {
            user = User.GetUser(conn, login, psw);
            if (user != null) role = Role.GetRole(conn, user.roleId);
            if (HasWatching)
            {
                watching = Watching.GetLastTakingWatching(conn, user.Id);
                if (watching == null) watching = new Watching(UserId);
            }
            return UserId != 0;
        }
        public bool CheckLogin(string login, string psw)
        {
            return user != null ? user.login == login && user.password == psw : false;
        }
        #endregion
    }
}
