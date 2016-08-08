using AppCommon.CommonBusiness;
using AppCommon.Constant;
using AppCommon.Util;
using DBManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using Utility.Password;

namespace AppCommon.Business
{
    public class UserBusiness : GenericBusiness<User>
    {
        public UserBusiness(User currentUser = null)
            : base(currentUser)
        {
            UseAuditTrail = true;
        }

        public virtual List<User> GetAll(bool ignoreDeleted = true)
        {
            List<User> users = new List<User>();
            try
            {
                AppLogger.logInfo(this.ToString(), string.Format("Begin getting users. Ignore deleted: {0}.", ignoreDeleted.ToString().ToUpperInvariant()));
                using (ThanhVanTranSysEntities context = new ThanhVanTranSysEntities())
                {
                    users = new List<User>(context.Users.ToList());
                    users.Sort(delegate(User userA, User userB)
                    {
                        return userA.user_name.CompareTo(userB.user_name);
                    });
                    if (ignoreDeleted)
                    {
                        users = users.Where(user => user.deleted == false).ToList();
                    }
                }
                AppLogger.logInfo(this.ToString(), string.Format("Finish getting users. Found: {0}.", users.Count));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), ex);
                System.Windows.Forms.MessageBox.Show(Constants.Messages.ERROR_OPERATION_NOT_PERFORMED, Constants.Messages.ERROR_CAPTION, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return users;
        }

        public override string Insert(User user)
        {
            string result = string.Empty;
            if (user != null)
            {
                try
                {
                    //AppLogger.logInfo(this.ToString(), "Begin inserting user.");
                    if (Repository.EntitiesSet.Any(u => u.user_name.Equals(user.user_name) && !u.deleted))
                    {
                        result = "Tên người dùng đã tồn tại.";
                        AppLogger.logInfo(this.ToString(), "User name already existed.");
                    }
                    else
                    {
                        result = base.Insert(user);
                    }
                    //AppLogger.logInfo(this.ToString(), "Finish inserting user.");
                }
                catch (Exception ex)
                {
                    AppLogger.logError(this.ToString(), ex);
                    result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
                }
            }
            else
            {
                AppLogger.logDebug(this.ToString(), "User is null.");
                result = "Thông tin người dùng không khả dụng.";
            }
            return result;
        }

        public override string Update(User user)
        {
            string result = string.Empty;
            if (user != null)
            {
                try
                {
                    //AppLogger.logInfo(this.ToString(), "Begin updating user.");
                    if (Repository.EntitiesSet.Any(u => !u.id.Equals(user.id) &&  u.user_name.Equals(user.user_name) && !u.deleted))
                    {
                        result = "Tên người dùng đã tồn tại.";
                        AppLogger.logInfo(this.ToString(), "User name already existed.");
                    }
                    else
                    {
                        // TO DO: Check for password change and encrypt password before updating
                        result = base.Update(user);
                    }
                    //AppLogger.logInfo(this.ToString(), "Finish updating user.");
                }
                catch (Exception ex)
                {
                    AppLogger.logError(this.ToString(), "Error occurs when updating user.", ex);
                    result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
                }
            }
            else
            {
                AppLogger.logDebug(this.ToString(), "User is null.");
                result = "Thông tin người dùng không khả dụng.";
            }
            return result;
        }

        public override string Delete(string id)
        {
            string result = string.Empty;
            try
            {
                AppLogger.logInfo(this.ToString(), "Begin deleting user.");
                User user = Repository.EntitiesSet.FirstOrDefault(u => u.id.Equals(id));
                AppLogger.logInfo(this.ToString(), string.Format("User {0}.", user != null ? "found" : "not found"));
                if (user != null)
                {
                    if (user.created_by.Equals("SYSTEM", StringComparison.InvariantCultureIgnoreCase))
                    {
                        result = "Không thể xóa người dùng hệ thống (System User).";
                        AppLogger.logInfo(this.ToString(), "System User cannot be deleted.");
                    }
                    else
                    {
                        user.deleted = true;
                        Repository.Commit();
                        AppLogger.logInfo(this.ToString(), "User deleted successfully.");
                    }
                }
                AppLogger.logInfo(this.ToString(), "Finish deleting user.");
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), "Error occurs when deleting user.", ex);
                result = Constants.Messages.ERROR_OPERATION_NOT_PERFORMED;
            }
            return result;
        }

        public virtual User ValidateUser(string userName, string password, string role)
        {
            // TO DO: implement a custom UserException to display custom error message
            User validatedUser = null;
            try
            {
                AppLogger.logInfo(this.ToString(), "Begin validating user.");
                validatedUser = Repository.Get(user =>
                                                user.user_name.Equals(userName, StringComparison.InvariantCultureIgnoreCase) &&
                                                user.role.Equals(role, StringComparison.InvariantCultureIgnoreCase) &&
                                                !user.deleted);
                if (validatedUser != null)
                {
                    if (PasswordServiceProvider.Match(userName.ToLowerInvariant(), password, validatedUser.password))
                    {
                        AppLogger.logInfo(this.ToString(), string.Format("User name & Password matched."));
                    }
                    else
                    {
                        validatedUser = null;
                        AppLogger.logInfo(this.ToString(), string.Format("User name & Password not matched."));
                        System.Windows.Forms.MessageBox.Show("Mật khẩu không chính xác.", Constants.Messages.ERROR_CAPTION, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }
                }
                else
                {
                    AppLogger.logInfo(this.ToString(), string.Format("User does not exist."));
                    System.Windows.Forms.MessageBox.Show("Tên người dùng không tồn tại.", Constants.Messages.ERROR_CAPTION, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                AppLogger.logInfo(this.ToString(), string.Format("Finish validating user.", userName));
            }
            catch (Exception ex)
            {
                AppLogger.logError(this.ToString(), "Error occurs when validating user.", ex);
                System.Windows.Forms.MessageBox.Show(Constants.Messages.ERROR_OPERATION_NOT_PERFORMED, Constants.Messages.ERROR_CAPTION, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return validatedUser;
        }
    }
}
