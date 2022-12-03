using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static CareerCloud.gRPC.Protos.SecurityLoginsLogService;

namespace CareerCloud.gRPC.Services
{
    public class SecurityLoginsLogController : SecurityLoginsLogServiceBase
    {
        private readonly SecurityLoginsLogLogic _logic;

        public SecurityLoginsLogController()
        {
            _logic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>());
        }

        public override Task<Empty> AddSecurityLoginsLog(SecurityLoginsLogs request, ServerCallContext context)
        {
            List<SecurityLoginsLogPoco> pocos = new List<SecurityLoginsLogPoco>();
            foreach (var item in request.SecLoginLog)
            {
                if (item is not null)
                {
                    pocos.Add(TranslateFrom(item));
                }

            }
            _logic.Add(pocos.ToArray());

            return Task.FromResult<Empty>(null);
        }
        private SecurityLoginsLogPoco TranslateFrom(SecurityLoginsLog proto)
        {
            return new SecurityLoginsLogPoco()
            {
                Id = Guid.Parse(proto.Id),
                Login = Guid.Parse(proto.Id),
                SourceIP = proto.SourceIP,
                LogonDate = proto.LogonDate.ToDateTime(),
                IsSuccesful = proto.IsSuccesful
            };
        }

        public override Task<Empty> UpdateSecurityLoginsLog(SecurityLoginsLogs request, ServerCallContext context)
        {
            List<SecurityLoginsLogPoco> pocos = new List<SecurityLoginsLogPoco>();
            foreach (var item in request.SecLoginLog)
            {
                pocos.Add(TranslateFrom(item));

            }
            _logic.Update(pocos.ToArray());

            return Task.FromResult<Empty>(null);
        }
        public override Task<Empty> DeleteSecurityLoginsLog(SecurityLoginsLogs request, ServerCallContext context)
        {
            List<SecurityLoginsLogPoco> pocos = new List<SecurityLoginsLogPoco>();
            foreach (var item in request.SecLoginLog)
            {
                pocos.Add(TranslateFrom(item));

            }
            _logic.Delete(pocos.ToArray());

            return Task.FromResult<Empty>(null);
        }
        public override Task<SecurityLoginsLogs> GetSecurityLoginsLogs(Empty request, ServerCallContext context)
        {
            List<SecurityLoginsLog> protos = new List<SecurityLoginsLog>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }
            SecurityLoginsLogs appEdus = new SecurityLoginsLogs();
            appEdus.SecLoginLog.AddRange(protos);
            return new Task<SecurityLoginsLogs>(() => appEdus);
        }
        public override Task<SecurityLoginsLog> GetSecurityLoginsLog(SecurityLoginsLogIdRequest request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);
            return new Task<SecurityLoginsLog>(() =>
            TranslateTo(_logic.Get(id)));
        }

        private SecurityLoginsLog TranslateTo(SecurityLoginsLogPoco poco)
        {

            return new SecurityLoginsLog()
            {

                Id = poco.Id.ToString(),
                Login = poco.Login.ToString(),
                SourceIP = poco.SourceIP,
                LogonDate = poco.LogonDate.ToTimestamp(),
                IsSuccesful = poco.IsSuccesful


            };
        }
    }
}

