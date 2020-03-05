namespace GunvorRecruitment.Repository  
{
    public class NodeManager  
    {
        private readonly  IRepository _nodeRepository;

        public NodeManager (IRepository nodeRepository)
        {
            _nodeRepository = nodeRepository;
        }

        public Node GetNodeAndImmediateChildren(string name)
        {
            var qdq = _nodeRepository.GetNodeAndImmediateChildren(name);
            return qdq;
            //return Activator.CreateInstance(typeof(Node), _nodeRepository.GetNodeAndImmediateChildren(name));
        }

       
    }
}
