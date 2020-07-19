using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Geomethod.Data;

namespace HospitalDepartment
{
    public struct DiagnosisInfo
    {
        [XmlAttribute]
        public int id;
        [XmlAttribute]
        public string code;
        [XmlAttribute]
        public string text;
        public bool IsEmpty { get { return id == 0; } }
        public DiagnosisInfo(int _id) { id = _id; code = ""; text = ""; }
        public static DiagnosisInfo Empty { get { return new DiagnosisInfo(0); } }
        //		public DiagnosisInfo(int id, string code, string text) { this.id = id;this.id,code=code;this.text=text; }
        public override string ToString()
        {
            return text;
        }
        public static implicit operator string(DiagnosisInfo di)
        {
            return di.text;
        }
        public Diagnosis GetDiagnosis(GmConnection conn)
        {
            return Diagnosis.GetDiagnosis(conn, id);
        }
    }
}