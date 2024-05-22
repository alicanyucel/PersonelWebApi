﻿namespace PersonelWebApi.Dros
{
    public sealed record CreatePersonelDto(
      string FirstName,
      string LastName,
      DateOnly StartingDate);
}
