using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Application.DTOs.Auth;

namespace ProjectManagementSystem.Application.Interfaces.Services;

public interface IAuthService
{
    Task<AuthResponse> RegisterAsync(RegisterUserRequest request);

    Task<AuthResponse> LoginAsync(LoginRequest request);
}
