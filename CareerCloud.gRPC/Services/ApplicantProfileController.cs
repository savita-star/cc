using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.gRPC.Protos;
using CareerCloud.Pocos;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using static CareerCloud.gRPC.Protos.ApplicantProfileService;

namespace CareerCloud.gRPC.Services
{
    public class ApplicantProfileController : ApplicantProfileServiceBase
    {
        private readonly ApplicantProfileLogic _logic;

        public ApplicantProfileController()
        {
            _logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>());
        }

        public override Task<Empty> AddApplicantProfile(ApplicantProfiles request, ServerCallContext context)
        {
            List<ApplicantProfilePoco> pocos = new List<ApplicantProfilePoco>();
            foreach (var item in request.AppPro)
            {
                pocos.Add(TranslateFrom(item));

            }
            _logic.Add(pocos.ToArray());

            return Task.FromResult<Empty>(null);
        }
        private ApplicantProfilePoco TranslateFrom(ApplicantProfile proto)
        {
            return new ApplicantProfilePoco()
            {
                Id = Guid.Parse(proto.Id),
                CurrentSalary = (decimal?)proto.CurrentSalary,
                CurrentRate = (decimal?)proto.CurrentRate,
                Currency = proto.Currency,
                Street = proto.Street,
                City = proto.City,
                Province = proto.Province,
                Country = proto.Country,
                PostalCode = proto.PostalCode,
                Login = Guid.Parse(proto.Login)
            };
        }

        public override Task<Empty> UpdateApplicantProfile(ApplicantProfiles request, ServerCallContext context)
        {
            List<ApplicantProfilePoco> pocos = new List<ApplicantProfilePoco>();
            foreach (var item in request.AppPro)
            {
                pocos.Add(TranslateFrom(item));

            }
            _logic.Update(pocos.ToArray());

            return Task.FromResult<Empty>(null);
        }
        public override Task<Empty> DeleteApplicantProfile(ApplicantProfiles request, ServerCallContext context)
        {
            List<ApplicantProfilePoco> pocos = new List<ApplicantProfilePoco>();
            foreach (var item in request.AppPro)
            {
                pocos.Add(TranslateFrom(item));

            }
            _logic.Delete(pocos.ToArray());

            return Task.FromResult<Empty>(null);
        }
        public override Task<ApplicantProfiles> GetApplicantProfiles(Empty request, ServerCallContext context)
        {
            List<ApplicantProfile> protos = new List<ApplicantProfile>();
            foreach (var item in _logic.GetAll())
            {
                protos.Add(TranslateTo(item));
            }
            ApplicantProfiles appEdus = new ApplicantProfiles();
            appEdus.AppPro.AddRange(protos);
            return new Task<ApplicantProfiles>(() => appEdus);
        }
        public override Task<ApplicantProfile> GetApplicantProfile(ApplicantProfileIdRequest request, ServerCallContext context)
        {
            Guid id = Guid.Parse(request.Id);
            return new Task<ApplicantProfile>(() =>
            TranslateTo(_logic.Get(id)));
        }

        private ApplicantProfile TranslateTo(ApplicantProfilePoco poco)
        {

            return new ApplicantProfile()
            {
                Id = poco.Id.ToString(),
                Login = poco.Login.ToString(),
                Street = poco.Street,
                City = poco.City,
                Province = poco.Province,
                PostalCode = poco.PostalCode,
                Country = poco.Country,
                Currency = poco.Currency,
                CurrentRate = (double?)poco.CurrentRate,
                CurrentSalary = (double?)poco.CurrentSalary

            };
        }
    }
}
