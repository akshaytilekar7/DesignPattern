using AdvanceList.Library;
using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceList.DataGenerator
{
    public class DummyDataService
    {
        List<Employee> DbLst;
        private readonly AvlManagement _avlManagement;
        public DummyDataService(AvlManagement avlManagement, int count)
        {
            var fixture = new Fixture();
            fixture.Customize<Employee>(c => c.With(x => x.Address));
            DbLst = fixture.CreateMany<Employee>(count).ToList();
            this._avlManagement = avlManagement;
        }
        public List<Employee> GetDataTraditional()
        {
            return DbLst;
        }
        public List<Employee> GetDataNewWay()
        {
            foreach (var item in DbLst)
                _avlManagement.Insert(item);
            return DbLst;
        }

        public List<int> GetAllByRandomIds() 
        {
            List<int> lst = new List<int>();

            foreach (var item in DbLst)
                lst.Add(item.Id);

            lst = lst.OrderBy(a => Guid.NewGuid()).ToList();
            return lst;
        }
        public bool AreSame()
        {
            var traditionalList = GetDataTraditional();
            var newList = GetDataNewWay();
            
            return traditionalList.All(newList.Contains);
        }
    }
}
