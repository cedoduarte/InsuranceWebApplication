namespace InsuranceWebApplication.Repositories
{
    public interface IUnitOfWork
    {
        ICarRepository CarRepository { get; }
        IUserRepository UserRepository { get; }
        IInsuranceRepository InsuranceRepository { get; }
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ICarRepository _carRepository;
        private readonly IUserRepository _userRepository;
        private readonly IInsuranceRepository _insuranceRepository;

        public UnitOfWork(ICarRepository carRepository, IUserRepository userRepository, IInsuranceRepository insuranceRepository)
        {
            _carRepository = carRepository;
            _userRepository = userRepository;
            _insuranceRepository = insuranceRepository;
        }

        public ICarRepository CarRepository { get => _carRepository; }
        public IUserRepository UserRepository { get => _userRepository; }
        public IInsuranceRepository InsuranceRepository { get => _insuranceRepository; }
    }
}
