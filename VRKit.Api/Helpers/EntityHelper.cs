using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VRKit.Common;
using VRKit.Models;
using VRKit.Models.Models;

namespace VRKit.Api.Helpers
{
    public class EntityHelper
    {
        private static VRKitEntities _db;
        public EntityHelper(VRKitEntities db) {
            _db = db;
        }

        public string Read_Lookup(string pKey, string pType) {
            var stringVal = _db.Read_Lookup(pKey, pType).FirstOrDefault().ToString();
            return stringVal;
        }

        public Read_Lookup_Defaults_List_Model Read_Lookup_Defaults()
        {
            var lookupList = _db.Read_Lookup_Defaults().ToList();
            var lookups = new Read_Lookup_Defaults_List_Model() {
                Lookup_List = new List<Read_Lookup_Defaults_Model>(),
                status = (int)Responses.Success,
                response = Responses.Success.ToString()
            };

            foreach (var item in lookupList) {
                lookups.Lookup_List.Add(new Read_Lookup_Defaults_Model {
                    Id = item.ID,
                    Key = item.Key,
                    NumValue = item.NumVAlue,
                    Type = item.Type
                });
            }

            return lookups;
        }

    }
}