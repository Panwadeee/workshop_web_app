namespace TodoApi.Dtos;

public record TodoGetDto(
    Guid Id,
    string Title,
    bool IsCompleted
);