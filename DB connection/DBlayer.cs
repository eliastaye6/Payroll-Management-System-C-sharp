using Payroll_Management_System.Model_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Management_System.DB_connection
{
    class DBlayer
    {

        private static string conStr = "server=.;database=PAYROLL;Uid=sa;pwd=ELIAS&GOD4ever;";



        public static User userLogin(string un, string pwd)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {


                SqlCommand cmd = new SqlCommand("userLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", un);
                cmd.Parameters.AddWithValue("@password", pwd);
                con.Open();
                try
                {
                    User loginUser = new User();
                    SqlDataReader sr = cmd.ExecuteReader();
                    sr.Read();
                    loginUser.userId = sr.GetInt32(0);
                    loginUser.username = sr.GetString(1);
                    // loginUser.password = sr.GetString(2);
                    loginUser.firstname = sr.GetString(3);
                    loginUser.lastname = sr.GetString(4);
                    if (!sr.IsDBNull(5))
                        loginUser.imageRecieve = sr.GetStream(5);
                    loginUser.Role = sr.GetString(6);

                    return loginUser;
                }
                catch (Exception e)
                {
                    //   MessageBox.Show("Returning null");
                    return null;
                }

            }
        }

        public static DataTable searchEmployee(string sk)
        {
            DataTable dt = new DataTable();
            //string url;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("searchEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sk", sk);
                SqlDataReader sr = cmd.ExecuteReader();

                dt.Load(sr);
            }
            return dt;

        }

        public static Employee fetchEmployee(int empId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("fetchEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empId", empId);
                    //TODO -ERTYUIKLKJGGFCVBNN
                    con.Open();

                    Employee emp = new Employee();
                    SqlDataReader sr = cmd.ExecuteReader();
                    sr.Read();
                    emp.employeeId = sr.GetInt32(0);
                    emp.firstname = sr.GetString(1);
                    emp.lastname = sr.GetString(2);
                    emp.sex = sr.GetString(3)[0];
                    emp.salary = sr.GetSqlMoney(4).ToDouble();
                    //nullable
                    if (!sr.IsDBNull(5))
                        emp.DOB = sr.GetDateTime(5).Date;
                    if (!sr.IsDBNull(6))
                        emp.DOE = sr.GetDateTime(6).Date;
                    if (!sr.IsDBNull(7))
                        emp.imageRecieve = sr.GetStream(7);


                    if (!sr.IsDBNull(8))
                        emp.telNo = sr.GetString(8);
                    if (!sr.IsDBNull(9))
                        emp.emergencyNo = sr.GetString(9);
                    if (!sr.IsDBNull(10))
                        emp.depId = sr.GetInt32(10);
                    if (!sr.IsDBNull(11))
                        emp.typeId = sr.GetInt32(11);
                    if (!sr.IsDBNull(12))
                        emp.groupId = sr.GetInt32(12);
                    if (!sr.IsDBNull(13))
                        emp.insertedBy = sr.GetInt32(13);

                    return emp;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }

        }

        public static void insertEmployee(Employee emp)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spInsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empFirstName", emp.firstname);
                cmd.Parameters.AddWithValue("@empLastName", emp.lastname);
                cmd.Parameters.AddWithValue("@empSex", emp.sex);
                cmd.Parameters.AddWithValue("@empBasicSalary", emp.salary);
                cmd.Parameters.AddWithValue("@empDateofBirth", emp.DOB);
                cmd.Parameters.AddWithValue("@empDateOfEmployment", emp.DOE);
                cmd.Parameters.AddWithValue("@empImage", emp.imageSend);
                cmd.Parameters.AddWithValue("@empTelNo", emp.telNo);
                cmd.Parameters.AddWithValue("@empEmergencyContact", emp.emergencyNo);
                cmd.Parameters.AddWithValue("@empDepId", emp.depId);
                cmd.Parameters.AddWithValue("@empTypeId", emp.typeId);
                cmd.Parameters.AddWithValue("@empGroupId", emp.groupId);
                cmd.Parameters.AddWithValue("@UserId", Main_Form.userId);

                cmd.ExecuteNonQuery();


            }
        }
        public static void updateEmployee(Employee emp)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spUpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empId", emp.employeeId);
                cmd.Parameters.AddWithValue("@empFirstName", emp.firstname);
                cmd.Parameters.AddWithValue("@empLastName", emp.lastname);
                cmd.Parameters.AddWithValue("@empSex", emp.sex);
                cmd.Parameters.AddWithValue("@empBasicSalary", emp.salary);
                cmd.Parameters.AddWithValue("@empDateofBirth", emp.DOB.Date);
                cmd.Parameters.AddWithValue("@empDateOfEmployment", emp.DOE.Date);
                cmd.Parameters.AddWithValue("@empImage", emp.imageSend);
                cmd.Parameters.AddWithValue("@empTelNo", emp.telNo);
                cmd.Parameters.AddWithValue("@empEmergencyContact", emp.emergencyNo);
                cmd.Parameters.AddWithValue("@empDepId", emp.depId);
                cmd.Parameters.AddWithValue("@empTypeId", emp.typeId);
                cmd.Parameters.AddWithValue("@empGroupId", emp.groupId);
                cmd.Parameters.AddWithValue("@UserId", Main_Form.userId);
                cmd.ExecuteNonQuery();

            }
        }
        public static void deleteEmployee(int empId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empId", empId);
                cmd.Parameters.AddWithValue("@UserID", Main_Form.userId);
                cmd.ExecuteNonQuery();
            }
        }


        public static void changeUserPassword(int userId, string oldPass, string newPass)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("changeUserPassword", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", userId);
                cmd.Parameters.AddWithValue("@oldPassword", oldPass);
                cmd.Parameters.AddWithValue("@newPassword", newPass);

                cmd.ExecuteNonQuery();


            }
        }

        public static void changeUserImage(int userId, byte[] image)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("changeUserImage", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", userId);
                cmd.Parameters.AddWithValue("@image", image);

                cmd.ExecuteNonQuery();


            }
        }
        public static bool checkConnection()
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                con.Close();
                return true;

            }
            catch (SqlException e)
            {
                return false;
            }
            catch (Exception eee)
            {
                Driver.Message(eee.Message, false);
                return false;
            }
        }
        /////////////////////////////
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sk"></param>
        /// <returns></returns>
        public static DataTable searchDepartment(string sk)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("searchDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sk", sk);
                SqlDataReader sr = cmd.ExecuteReader();

                dt.Load(sr);
            }
            return dt;

        }
        //TODO -method that fetches department
        public static Department fetchDepartment(int depId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("fetchDepartment", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@depId", depId);
                    con.Open();

                    Department department = new Department();
                    SqlDataReader sr = cmd.ExecuteReader();
                    sr.Read();
                    department.depId = sr.GetInt32(0);
                    department.depName = sr.GetString(1);

                    //nullable
                    if (!sr.IsDBNull(2))
                        department.depDescription = sr.GetString(2);


                    return department;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }

        }
        //TODO - insert new department


        public static SortedList<int, string> fetchAllDepartment()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("fetchAllDepartments", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SortedList<int, string> depList = new SortedList<int, string>();
                    Department department = new Department();
                    SqlDataReader sr = cmd.ExecuteReader();
                    while (sr.Read())
                    {

                        department.depId = sr.GetInt32(0);
                        department.depName = sr.GetString(1);

                        depList.Add(department.depId, department.depName);



                    }
                    return depList;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }
        }
        public static void insertDepartment(Department department)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spInsertDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@depName", department.depName);
                cmd.Parameters.AddWithValue("@description", department.depDescription);


                cmd.ExecuteNonQuery();


            }
        }
        //TODO -update department
        public static void updateDepartment(Department dep)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spUpdateDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@depId", dep.depId);
                cmd.Parameters.AddWithValue("@depName", dep.depName);
                cmd.Parameters.AddWithValue("@description", dep.depDescription);
                cmd.Parameters.AddWithValue("userId", Main_Form.userId);
                cmd.ExecuteNonQuery();

            }
        }
        //TODO - delete department
        public static void deleteDepartment(int depId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@depId", depId);
                cmd.Parameters.AddWithValue("@UserID", Main_Form.userId);
                cmd.ExecuteNonQuery();
            }
        }
        public static DataTable searchEmpType(string sk)
        {
            DataTable dt = new DataTable();
            //string url;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SearchEmployeeType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sk", sk);
                SqlDataReader sr = cmd.ExecuteReader();

                dt.Load(sr);
            }
            return dt;
        }
        public static void insertEmpType(EmpType emp)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spInsertEmployeeType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empTypeName", emp.TypeName);
                cmd.Parameters.AddWithValue("@empTypeDescription", emp.TypeDescription);

                cmd.ExecuteNonQuery();


            }
        }
        public static void updateEmpType(EmpType emp)
        {

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spUpdateEmployeeType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empTypeId", emp.TypeID);
                cmd.Parameters.AddWithValue("@empTypeName", emp.TypeName);
                cmd.Parameters.AddWithValue("@empTypeDescription", emp.TypeDescription);

                cmd.ExecuteNonQuery();


            }
        }
        public static void deleteEmpType(int TypeId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteEmployeeType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empTypeId", TypeId);
                cmd.ExecuteNonQuery();
            }
        }
        public static EmpType fetchEmpType(int TypeId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("fetchEmployeeType", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empTypeId", TypeId);

                    con.Open();

                    EmpType emp = new EmpType();
                    SqlDataReader sr = cmd.ExecuteReader();
                    sr.Read();
                    emp.TypeID = sr.GetInt32(0);
                    emp.TypeName = sr.GetString(1);
                    if (!sr.IsDBNull(2))
                        emp.TypeDescription = sr.GetString(2);

                    return emp;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }

        }

        public static SortedList<int, string> fetchAllEmpTypes()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("fetchAllEmpTypes", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SortedList<int, string> ls = new SortedList<int, string>();
                    con.Open();

                    EmpType emp = new EmpType();
                    SqlDataReader sr = cmd.ExecuteReader();
                    sr.Read();
                    emp.TypeID = sr.GetInt32(0);
                    emp.TypeName = sr.GetString(1);
                    ls.Add(emp.TypeID, emp.TypeName);

                    return ls;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }

        }
        public static DataTable searchGroup(string sk)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("searchGroup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sk", sk);
                SqlDataReader sr = cmd.ExecuteReader();

                dt.Load(sr);
            }
            return dt;

        }
        //TODO -method that fetches group
        public static Groups fetchGroup(int groupId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("fetchGroup", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@groupId", groupId);
                    con.Open();

                    Groups group = new Groups();
                    SqlDataReader sr = cmd.ExecuteReader();
                    sr.Read();
                    group.groupId = sr.GetInt32(0);
                    group.groupName = sr.GetString(1);

                    //nullable
                    if (!sr.IsDBNull(2))
                        group.groupDescription = sr.GetString(2);


                    return group;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }

        }
        public static SortedList<int, string> fetchAllGroups()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("fetchAllGroups", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();

                    Groups group = new Groups();
                    SqlDataReader sr = cmd.ExecuteReader();
                    SortedList<int, string> ls = new SortedList<int, string>();
                    while (sr.Read())
                    {
                        group.groupId = sr.GetInt32(0);
                        group.groupName = sr.GetString(1);
                        ls.Add(group.groupId, group.groupName);

                    }
                    //nullable



                    return ls;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }

        }
        //TODO - insert new group
        public static void insertGroup(Groups group)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spInsertGroup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@groupName", group.groupName);
                cmd.Parameters.AddWithValue("@groupDescription", group.groupDescription);


                cmd.ExecuteNonQuery();


            }
        }
        //TODO -update 
        public static void updateGroup(Groups group)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spUpdateGroup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@groupId", group.groupId);
                cmd.Parameters.AddWithValue("@groupName", group.groupName);
                cmd.Parameters.AddWithValue("@groupDescription", group.groupDescription);

                cmd.ExecuteNonQuery();

            }
        }
        //TODO - delete group
        public static void deleteGroup(int groupId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteGroup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@groupId", groupId);

                cmd.ExecuteNonQuery();
            }
        }
        //TODO -search group
        public static void insertOverTime(OverTime ot)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spInsertOT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@otName", ot.otName);
                cmd.Parameters.AddWithValue("@hourlyRate", ot.hrRate);
                cmd.Parameters.AddWithValue("@startTime", ot.TimeStart);
                cmd.Parameters.AddWithValue("@endTime", ot.TimeEnd);
                cmd.Parameters.AddWithValue("@description", ot.otDesc);

                cmd.ExecuteNonQuery();

            }
        }
        public static void updateOverTime(OverTime ot)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spUpdateOT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@otId", ot.otId);
                cmd.Parameters.AddWithValue("@otName", ot.otName);
                cmd.Parameters.AddWithValue("@hourlyRate", ot.hrRate);
                cmd.Parameters.AddWithValue("@startTime", ot.TimeStart);
                cmd.Parameters.AddWithValue("@endTime", ot.TimeEnd);
                cmd.Parameters.AddWithValue("@description", ot.otDesc);
                cmd.Parameters.AddWithValue("@userId", Main_Form.userId);

                cmd.ExecuteNonQuery();

            }
        }
        public static void deleteOverTime(int otId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteOT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@otID", otId);
                cmd.Parameters.AddWithValue("@userId", Main_Form.userId);
                cmd.ExecuteNonQuery();
            }

        }
        public static DataTable searchOverTime(string sk)
        {
            DataTable dt = new DataTable();
            //string url;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SearchOverTime", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sk", sk);
                SqlDataReader sr = cmd.ExecuteReader();

                dt.Load(sr);
            }
            return dt;
        }
        public static OverTime fetchOverTime(int otId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("fetchOverTime", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@otId", otId);
                    con.Open();

                    OverTime ot = new OverTime();
                    SqlDataReader sr = cmd.ExecuteReader();
                    sr.Read();
                    ot.otId = sr.GetInt32(0);
                    ot.otName = sr.GetString(1);
                    //nullable
                    if (!sr.IsDBNull(2))
                        ot.hrRate = sr.GetDouble(2);


                    if (!sr.IsDBNull(3))
                        ot.TimeStart = sr.GetDateTime(3);
                    if (!sr.IsDBNull(4))
                        ot.TimeEnd = sr.GetDateTime(4);
                    if (!sr.IsDBNull(5))
                        ot.otDesc = sr.GetString(5);



                    return ot;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }
        }



        public static void insertUser(User usr)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insertUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", usr.username);
                cmd.Parameters.AddWithValue("@password", usr.password);
                cmd.Parameters.AddWithValue("@firstName", usr.firstname);
                cmd.Parameters.AddWithValue("@lastName", usr.lastname);
                cmd.Parameters.AddWithValue("@userImage", usr.imageSend);
                cmd.Parameters.AddWithValue("@role", usr.Role);


                cmd.ExecuteNonQuery();


            }
        }
        public static void updateUser(User usr)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("updateUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userID", usr.userId);
                cmd.Parameters.AddWithValue("@username", usr.username);
                cmd.Parameters.AddWithValue("@password", usr.password);
                cmd.Parameters.AddWithValue("@firstName", usr.firstname);
                cmd.Parameters.AddWithValue("@lastName", usr.lastname);
                cmd.Parameters.AddWithValue("@userImage", usr.imageSend);
                cmd.Parameters.AddWithValue("@role", usr.Role);

                cmd.ExecuteNonQuery();


            }
        }
        public static void deleteUser(int usrId)
        {

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("deleteUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@userId", usrId);

                cmd.ExecuteNonQuery();
            }

        }
        public static DataTable searchUser(string sk)
        {
            DataTable dt = new DataTable();
            //string url;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SearchUsers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sk", sk);
                SqlDataReader sr = cmd.ExecuteReader();

                dt.Load(sr);
            }
            return dt;
        }
        public static User fetchUser(int usrId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("fetchUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userId", usrId);
                    con.Open();

                    User usr = new User();
                    SqlDataReader sr = cmd.ExecuteReader();
                    sr.Read();
                    usr.userId = sr.GetInt32(0);
                    usr.username = sr.GetString(1);
                    //  usr.password = sr.GetString(2);
                    usr.firstname = sr.GetString(2);
                    usr.lastname = sr.GetString(3);

                    if (!sr.IsDBNull(4))
                        usr.imageRecieve = sr.GetStream(4);
                    usr.Role = sr.GetString(5);

                    return usr;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }
        }



        ////mondata below
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sk"></param>
        /// <returns></returns>
        public static DataTable searchMonthlyData(string sk)
        {
            DataTable dt = new DataTable();
            //string url;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("searchMonthlyData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sk", sk);
                SqlDataReader sr = cmd.ExecuteReader();

                dt.Load(sr);
            }
            return dt;
        }


        public static void insertMonthlyData(MonthlyData mon)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("spInsertMonData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empId", mon.empId);
                cmd.Parameters.AddWithValue("@monDataMonth", DateTime.Now.Month);
                cmd.Parameters.AddWithValue("@monDataYear", DateTime.Now.Year);
                cmd.Parameters.AddWithValue("@monDataUnpaidSalary", mon.UnpaidSalary);
                cmd.Parameters.AddWithValue("@monDataUnpaidPension", mon.UnpaidPension);
                cmd.Parameters.AddWithValue("@monDataUnpaidIncomeTax", mon.UnpaidIncomeTax);
                cmd.Parameters.AddWithValue("@monDataIncentive", mon.Incentive);
                cmd.Parameters.AddWithValue("@monDataMedical", mon.Medical);
                cmd.Parameters.AddWithValue("@monDataCourtCase", mon.CourtCase);
                cmd.Parameters.AddWithValue("@monDataFine", mon.Fine);
                cmd.Parameters.AddWithValue("@monDataOverPayment", mon.OverPayment);
                cmd.Parameters.AddWithValue("@monDataActingAllowance", mon.ActingAllowance);
                cmd.Parameters.AddWithValue("@monDataMobileandTransport", mon.MobileandTransport);
                cmd.Parameters.AddWithValue("@monDataSaving", mon.Saving);
                cmd.Parameters.AddWithValue("@monDataOtherContribution", mon.OtherContribution);
                cmd.Parameters.AddWithValue("@UserId", Main_Form.userId);

                cmd.ExecuteNonQuery();


            }
        }



        public static void updateMonthlyData(MonthlyData mon)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("spUpdateMonData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empId", mon.empId);
                cmd.Parameters.AddWithValue("@monDataMonth", DateTime.Now.Month);
                cmd.Parameters.AddWithValue("@monDataYear", DateTime.Now.Year);
                cmd.Parameters.AddWithValue("@monDataUnpaidSalary", mon.UnpaidSalary);
                cmd.Parameters.AddWithValue("@monDataUnpaidPension", mon.UnpaidPension);
                cmd.Parameters.AddWithValue("@monDataUnpaidIncomeTax", mon.UnpaidIncomeTax);
                cmd.Parameters.AddWithValue("@monDataIncentive", mon.Incentive);
                cmd.Parameters.AddWithValue("@monDataMedical", mon.Medical);
                cmd.Parameters.AddWithValue("@monDataCourtCase", mon.CourtCase);
                cmd.Parameters.AddWithValue("@monDataFine", mon.Fine);
                cmd.Parameters.AddWithValue("@monDataOverPayment", mon.OverPayment);
                cmd.Parameters.AddWithValue("@monDataActingAllowance", mon.ActingAllowance);
                cmd.Parameters.AddWithValue("@monDataMobileandTransport", mon.MobileandTransport);
                cmd.Parameters.AddWithValue("@monDataSaving", mon.Saving);
                cmd.Parameters.AddWithValue("@monDataOtherContribution", mon.OtherContribution);
                cmd.Parameters.AddWithValue("@UserId", Main_Form.userId);

                cmd.ExecuteNonQuery();


            }
        }



        public static void deleteMonthlyData(int empId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spDeleteMonData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empId", empId);
                cmd.Parameters.AddWithValue("@monDataMonth", DateTime.Now.Month);
                cmd.Parameters.AddWithValue("@monDataYear", DateTime.Now.Year);
                cmd.Parameters.AddWithValue("@UserID", Main_Form.userId);
                cmd.ExecuteNonQuery();
            }
        }



        public static MonthlyData fetchMonthlyData(int empId)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("fetchMonthlyData", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empId", empId);
                    //TODO -ERTYUIKLKJGGFCVBNN
                    con.Open();

                    MonthlyData mon = new MonthlyData();
                    SqlDataReader sr = cmd.ExecuteReader();
                    sr.Read();
                    mon.empId = sr.GetInt32(0);
                    mon.FullName = sr.GetString(1);
                    if (!sr.IsDBNull(2))
                        mon.imageRecieve = sr.GetStream(2);
                    mon.UnpaidSalary = sr.GetSqlMoney(3).ToDouble();
                    mon.UnpaidPension = sr.GetSqlMoney(4).ToDouble();
                    mon.UnpaidIncomeTax = sr.GetSqlMoney(5).ToDouble();
                    mon.Incentive = sr.GetSqlMoney(6).ToDouble();
                    mon.Medical = sr.GetSqlMoney(7).ToDouble();
                    mon.CourtCase = sr.GetSqlMoney(8).ToDouble();
                    mon.Fine = sr.GetSqlMoney(9).ToDouble();
                    mon.OverPayment = sr.GetSqlMoney(10).ToDouble();
                    mon.ActingAllowance = sr.GetSqlMoney(11).ToDouble();
                    mon.MobileandTransport = sr.GetSqlMoney(12).ToDouble();
                    mon.Saving = sr.GetSqlMoney(13).ToDouble();
                    mon.OtherContribution = sr.GetSqlMoney(14).ToDouble();

                    return mon;
                }
                catch (Exception e)
                {
                    //  MessageBox.Show(e.Message);
                    return null;
                }
            }

        }

        public static MonthlyData fetchMonthlyDataDate(int empId, DateTime date)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("fetchMonthlyDataDate", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empId", empId);
                    cmd.Parameters.AddWithValue("@Date", date);
                    //TODO -ERTYUIKLKJGGFCVBNN
                    con.Open();

                    MonthlyData mon = new MonthlyData();
                    SqlDataReader sr = cmd.ExecuteReader();
                    sr.Read();
                    mon.empId = sr.GetInt32(0);

                    mon.FullName = sr.GetString(1);
                    if (!sr.IsDBNull(2))
                        mon.imageRecieve = sr.GetStream(2);
                    mon.UnpaidSalary = sr.GetSqlMoney(3).ToDouble();
                    mon.UnpaidPension = sr.GetSqlMoney(4).ToDouble();
                    mon.UnpaidIncomeTax = sr.GetSqlMoney(5).ToDouble();
                    mon.Incentive = sr.GetSqlMoney(6).ToDouble();
                    mon.Medical = sr.GetSqlMoney(7).ToDouble();
                    mon.CourtCase = sr.GetSqlMoney(8).ToDouble();
                    mon.Fine = sr.GetSqlMoney(9).ToDouble();
                    mon.OverPayment = sr.GetSqlMoney(10).ToDouble();
                    mon.ActingAllowance = sr.GetSqlMoney(11).ToDouble();
                    mon.MobileandTransport = sr.GetSqlMoney(12).ToDouble();
                    mon.Saving = sr.GetSqlMoney(13).ToDouble();
                    mon.OtherContribution = sr.GetSqlMoney(14).ToDouble();

                    return mon;
                }
                catch (Exception e)
                {
                    // MessageBox.Show(e.Message);
                    return null;
                }
            }


        }

        public static int fetchAttendanceCount(int empId, DateTime date)
        {

            try
            {
                int count;
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spCountAttendance", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empId", empId);
                    cmd.Parameters.AddWithValue("@Date", date);
                    //TODO -ERTYUIKLKJGGFCVBNN

                    count = (int)cmd.ExecuteScalar();


                }
                return count;
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                return 0;
            }
            catch (Exception e)
            {
                return 0;
            }
        }



        public static DataTable fetchOverTime(int empId, DateTime date)
        {
            DataTable dt = new DataTable();
            //string url;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spViewOverTimeDetail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empId", empId);
                cmd.Parameters.AddWithValue("@date", date);
                SqlDataReader sr = cmd.ExecuteReader();

                dt.Load(sr);
            }
            return dt;

        }

        public static DataTable searchScheduledOt(string sk)
        {
            DataTable dt = new DataTable();
            //string url;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("searchOverTimeSchedule", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sk", sk);

                SqlDataReader sr = cmd.ExecuteReader();

                dt.Load(sr);
            }
            return dt;
        }
        public static SortedList<int, string> fetchAllOvertime()
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("fetchAllOverTime", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();


                    SqlDataReader sr = cmd.ExecuteReader();
                    SortedList<int, string> ls = new SortedList<int, string>();
                    while (sr.Read())
                    {
                        int id = sr.GetInt32(0);
                        string name = sr.GetString(1);
                        ls.Add(id, name);

                    }
                    //nullable



                    return ls;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return null;
                }
            }

        }

        public static OtSchedule fetchOtSchedule(int empId)
        {
            OtSchedule ot = new OtSchedule();

            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("fetchOverTimeSchedule", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empID", empId);
                    con.Open();


                    SqlDataReader sr = cmd.ExecuteReader();
                    sr.Read();
                    if (!sr.IsDBNull(0))
                        ot.date = sr.GetDateTime(0).Date;

                    ot.typeId = sr.GetInt32(1);



                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }
            }


            return ot;
        }


        public static void insertOvertimeSchedule(OtSchedule ot)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("InsertOverTimeSchedule", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empID", ot.empId);
                    cmd.Parameters.AddWithValue("@Date", ot.date);
                    cmd.Parameters.AddWithValue("@otType", ot.typeId);
                    cmd.Parameters.AddWithValue("@insertedBy",Main_Form.userId );
                    con.Open();


                    cmd.ExecuteNonQuery();

                    Driver.Message("A NEW OVERTIME SCHEDULE IS ADDED SUCCESFULLY", false);


                }
                catch (Exception e)
                {
                    Driver.Message(e.Message, false);
                

                }
            }
        }


        public static void updateOvertimeSchedule(OtSchedule ot)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("updateOverTimeSchedule", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empID", ot.empId);
                    cmd.Parameters.AddWithValue("@Date", ot.date);
                    cmd.Parameters.AddWithValue("@otType", ot.typeId);
                    cmd.Parameters.AddWithValue("@insertedBy", Main_Form.userId);
                    con.Open();


                    cmd.ExecuteNonQuery();

                  


                }
                catch (Exception e)
                {
                    Driver.Message(e.Message, false);


                }
            }
        }

        public static void deleteOvertimeSchedule(OtSchedule ot)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("deleteOverTimeSchedule", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empID", ot.empId);
                    cmd.Parameters.AddWithValue("@Date", ot.date);
                    cmd.Parameters.AddWithValue("@otType", ot.typeId);
                    con.Open();


                    cmd.ExecuteNonQuery();




                }
                catch (Exception e)
                {
                    Driver.Message(e.Message, false);


                }
            }
        }
    }
}






        
    


