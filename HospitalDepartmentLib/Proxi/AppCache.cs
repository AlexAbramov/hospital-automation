using System;
using System.Collections.Generic;
using System.Text;
using Geomethod;
using Geomethod.Data;

namespace HospitalDepartment
{
    public class AppCache
    {
        Dictionary<int, Role> roles = new Dictionary<int, Role>();
        Dictionary<int, User> users = new Dictionary<int, User>();
        WatchingList watchingList = new WatchingList();
        Dictionary<int, Diagnosis> diagnoses = new Dictionary<int, Diagnosis>();
        List<PrescriptionType> prescriptionTypes = new List<PrescriptionType>();

        public IEnumerable<PrescriptionType> PrescriptionTypes { get { return prescriptionTypes; } }

        public AppCache() { }

        public void Update(GmConnection conn, int watchingGroupId)
        {
            Clear();
            Role.GetRoles(conn, roles);
            User.GetUsers(conn, users);
            UpdateWatchingList(conn, watchingGroupId);
            Diagnosis.GetDiagnoses(conn, diagnoses);
            PrescriptionType.GetPrescriptionTypes(conn, prescriptionTypes);
        }

        private void UpdateWatchingList(GmConnection conn, int watchingGroupId)
        {
            watchingList.Clear();
            foreach (Role role in roles.Values)
            {
                if (role.watchingGroupId == watchingGroupId)
                {
                    watchingList.UpdateList(conn, role.Id);
                }
            }
        }

        private void Clear()
        {
            roles.Clear();
            users.Clear();
            watchingList.Clear();
            diagnoses.Clear();
            prescriptionTypes.Clear();
        }

        public User GetWatchingUser(int patientId)
        {
            foreach (Watching watching in watchingList)
            {
                if (watching.HasPatient(patientId))
                {
                    int userId = watching.userId;
                    return users.ContainsKey(userId) ? users[userId] : null;
                }
            }
            return null;
        }

        public string GetUserName(int userId)
        {
            foreach (User user in users.Values)
            {
                if (user.Id==userId)
                {
                    return user.NonEmptyName;
                }
            }
            return "¹"+userId.ToString();
        }

        public Diagnosis GetDiagnosis(int diagnosisId)
        {
            return diagnoses.ContainsKey(diagnosisId) ? diagnoses[diagnosisId] : null;
        }
    }
}
