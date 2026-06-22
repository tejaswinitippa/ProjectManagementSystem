using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ProjectManagementSystem.Application.DTOs.Auth;
using ProjectManagementSystem.Application.Interfaces.Repositories;
using ProjectManagementSystem.Application.Interfaces.Services;
using ProjectManagementSystem.Domain.Entities;
using ProjectManagementSystem.Domain.Enums;

namespace ProjectManagementSystem.Application.Services;

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly PasswordHasher<User> _passwordHasher;

    public AuthService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
        _passwordHasher = new PasswordHasher<User>();
    }

    public async Task<AuthResponse> RegisterAsync(RegisterUserRequest request)
    {
        var existingUser = await _userRepository.GetByEmailAsync(request.Email);

        if (existingUser != null)
        {
            throw new Exception("User already exists.");
        }

        var user = new User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            Role = UserRole.Developer
        };

        user.PasswordHash =
            _passwordHasher.HashPassword(user, request.Password);

        await _userRepository.AddAsync(user);
        await _userRepository.SaveChangesAsync();

        return new AuthResponse
        {
            Email = user.Email,
            Role = user.Role.ToString(),
            Token = string.Empty
        };
    }

    public async Task<AuthResponse> LoginAsync(LoginRequest request)
    {
        throw new NotImplementedException();
    }
}
