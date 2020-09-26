using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UVASurplus.Data;
using UVASurplus.Models;

namespace UVASurplus.Data
{
    public class DbInitializer
    {

        public static void Initialize(UVASurplusContext context)
        {

            context.Database.EnsureCreated();

            //look for data
            if (context.Request.Any())
                {
                    return;
                }

            var requests = new Request[]
            {
                new Request{RequesterName="Katie Goodrich", ComputingID="keg4ky", RequesterEmail="keg4ky@virginia.edu", RequesterDepartment="FM", RequesterPhoneNumber="7579477343", RequesterBuilding="Building"
                ,RequesterRoom="room",DesiredDate=DateTime.Parse("2020-11-10"),AdditionalComments="I don't have anything else to say",NeedPickup=true,OProject=1123,OTask=123,OAward=555,OOrg=444,TaggedAssets=true
                ,RequestDate=DateTime.Parse("2020-09-15"),AdditionalReviewer=false,AdditionalReviewerCompID="",RequestStatus="Submitted"} ,

                new Request{RequesterName="Katie Goodrich", ComputingID="keg4ky", RequesterEmail="keg4ky@virginia.edu", RequesterDepartment="FM", RequesterPhoneNumber="7579477343", RequesterBuilding="Building"
                ,RequesterRoom="room",DesiredDate=DateTime.Parse("2020-12-10"),AdditionalComments="This is my second request",NeedPickup=true,OProject=1123,OTask=123,OAward=555,OOrg=444,TaggedAssets=true
                ,RequestDate=DateTime.Parse("2020-09-15"),AdditionalReviewer=false,AdditionalReviewerCompID="",RequestStatus="Submitted"} ,

                new Request{RequesterName="Katie Goodrich", ComputingID="keg4ky", RequesterEmail="keg4ky@virginia.edu", RequesterDepartment="FM", RequesterPhoneNumber="7579477343", RequesterBuilding="Building"
                ,RequesterRoom="room",DesiredDate=DateTime.Parse("2020-12-15"),AdditionalComments="This is my third request",NeedPickup=true,OProject=1123,OTask=123,OAward=555,OOrg=444,TaggedAssets=true
                ,RequestDate=DateTime.Parse("2020-09-15"),AdditionalReviewer=false,AdditionalReviewerCompID="",RequestStatus="Submitted"}
            };

            context.Request.AddRange(requests);
            context.SaveChanges();

            var items = new Item[]
            {
                new Item{RequestID=1,AssetTag=1234,ItemType="Electronic",ItemDescription="electric chair",Quantity=2,Condition="poor",Comments="Gently used",Serial="5503039"
                ,EquipmentType="Electric Furniture",Manufacturer="GE",Model="s"},
                new Item{RequestID=1,AssetTag=1111,ItemType="Electronic",ItemDescription="electric guitar",Quantity=2,Condition="good",Comments="Gently smashed",Serial="5503039"
                ,EquipmentType="Instrument",Manufacturer="GE",Model="s"},
                new Item{RequestID=2,AssetTag=4444,ItemType="Furniture",ItemDescription="regular chair",Quantity=2,Condition="poor",Comments="Gently used"},
                new Item{RequestID=2,AssetTag=5555,ItemType="Furniture",ItemDescription="coconut",Quantity=2,Condition="great",Comments="I don't want it"},
                new Item{RequestID=3,AssetTag=6666,ItemType="Other",ItemDescription="rabbit",Quantity=2,Condition="poor",Comments="slightly chewed"},
                new Item{RequestID=3,AssetTag=7777,ItemType="Electronic",ItemDescription="electric collar",Quantity=2,Condition="poor",Comments="for the rabbit",Serial="787878"
                ,EquipmentType="Electric wearables",Manufacturer="GE",Model="T"}
            };

            context.Item.AddRange(items);
            context.SaveChanges();

        }
    }
}
