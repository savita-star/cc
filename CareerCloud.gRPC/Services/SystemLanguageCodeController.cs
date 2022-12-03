using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static CareerCloud.gRPC.Protos.SystemLanguageCodeService;

namespace CareerCloud.gRPC.Services
{
    public class SystemLanguageCodeController : SystemLanguageCodeServiceBase
    {
        private readonly SystemLanguageCodeLogic _logic;

        public SystemLanguageCodeController()
        {
            _logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>());
        }

        public override Task<Empty> AddSystemLanguageCode(SystemLanguageCodes request, ServerCallContext context)
        {
            List<SystemLanguageCodePoco> pocos = new List<SystemLanguageCodePoco>();
            foreach (var item in request.SysLangCode)
            {
                pocos.Add(TranslateFrom(item));

            }
            _logic.Add(pocos.ToArray());

            return Task.FromResult<Empty>(null);
        }
        private SystemLanguageCodePoco TranslateFrom(SystemLanguageCode proto)
        {
            return new SystemLanguageCodePoco()
            {
                LanguageID = proto.LanguageID,
                Name = proto.Name,
                NativeName = proto.NativeName
            };
        }

        public override Task<Empty> UpdateSystemLanguageCode(SystemLanguageCodes request, ServerCallContext context)
        {
            List<SystemLanguageCodePoco> pocos = new List<SystemLanguageCodePoco>();
            foreach (var item in request.SysLangCode)
            {
                pocos.Add(TranslateFrom(item));

            }
            _logic.Update(pocos.ToArray());

            return Task.FromResult<Empty>(null);
        }
        public override Task<Empty> DeleteSystemLanguageCode(SystemLanguageCodes request, ServerCallContext context)
        {
            List<SystemLanguageCodePoco> pocos = new List<SystemLanguageCodePoco>();
            foreach (var item in request.SysLangCode)
            {
                pocos.Add(TranslateFrom(item));

            }
            _logic.Delete(pocos.ToArray());

            return Task.FromResult<Empty>(null);
        }
        public override Task<SystemLanguageCodes> GetSystemLanguageCodes(Empty request, ServerCallContext context)
        {
            List<SystemLanguageCode> protos = new List<SystemLanguageCode>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }
            SystemLanguageCodes appEdus = new SystemLanguageCodes();
            appEdus.SysLangCode.AddRange(protos);
            return new Task<SystemLanguageCodes>(() => appEdus);
        }
        public override Task<SystemLanguageCode> GetSystemLanguageCode(SystemLanguageCodeIdRequest request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);
            return new Task<SystemLanguageCode>(() => TranslateTo(_logic.Get(id.ToString())));
        }

        private SystemLanguageCode TranslateTo(SystemLanguageCodePoco poco)
        {

            return new SystemLanguageCode()
            {
                LanguageID = poco.LanguageID,
                Name = poco.Name,
                NativeName = poco.NativeName
            };
        }
    }
}
