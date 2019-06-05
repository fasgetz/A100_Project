using Nelibur.ServiceModel.Services;
using Nelibur.ServiceModel.Services.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace test
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.


    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Service1 : IService1
    {


        public Service1()
        {
            NeliburRestService.Configure(x =>
            {
                x.Bind<CreateClientRequest, ClientProcessor>();
                x.Bind<UpdateClientRequest, ClientProcessor>();
                x.Bind<DeleteClientRequest, ClientProcessor>();
                x.Bind<GetClientRequest, ClientProcessor>();
            });
        }

        public string GetData(int value)
        {
            //Message message = new Message();
            //NeliburRestService.Process(message);
            

            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }

    public class ClientProcessor : IPost<CreateClientRequest>,
                                    IGet<GetClientRequest>,
                                    IDeleteOneWay<DeleteClientRequest>,
                                    IPut<UpdateClientRequest>
    {
        private static List<Client> _clients = new List<Client>();

        public void DeleteOneWay(DeleteClientRequest request)
        {
            Console.WriteLine("Delete Request: {0}\n", request);
            _clients = _clients.Where(x => x.Id != request.Id).ToList();
        }

        public object Get(GetClientRequest request)
        {
            Console.WriteLine("Get Request: {0}", request);
            Client client = _clients.Single(x => x.Id == request.Id);
            return new ClientResponse { Id = client.Id, Email = client.Email };
        }

        public object Post(CreateClientRequest request)
        {
            Console.WriteLine("Post Request: {0}", request);
            var client = new Client
            {
                Id = Guid.NewGuid(),
                Email = request.Email
            };
            _clients.Add(client);
            return new ClientResponse { Id = client.Id, Email = client.Email };
        }

        public object Put(UpdateClientRequest request)
        {
            Console.WriteLine("Put Request: {0}", request);
            Client client = _clients.Single(x => x.Id == request.Id);
            client.Email = request.Email;
            return new ClientResponse { Id = client.Id, Email = client.Email };
        }
    }

}
