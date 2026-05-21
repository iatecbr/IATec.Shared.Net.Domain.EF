# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

## [1.3.0] - 2026-05-20

### ADDED
- Added XML documentation summaries to all interfaces and public methods for improved IntelliSense support across consuming projects.
- Added comprehensive README with usage examples and target framework details.
- Introduced this CHANGELOG to track project evolution.

## [1.2.0] - 2024-XX-XX

### CHANGED
- Updated project to target **.NET 10** alongside .NET 8 and .NET 9.
- Upgraded internal dependency `IATec.Shared.Domain` to version `1.2.0`.

---

## [1.0.0] - 2024-XX-XX

### ADDED
- Initial stable release of the package.
- Established versioning at `1.0.0` for production use.

### CHANGED
- Changed package version from `0.2.1` to `1.0.0`.
- Updated project metadata and build pipeline configuration.

---

## [0.2.1] and earlier

### ADDED
- Started the project with core EF domain contracts (`IUnitOfWork`, `ITransaction`, `IReadRepository<T>`, `IWriteRepository<T>`, `IGenericRepositoryQuery`).
- Created Azure Pipelines build and NuGet push automation.

### FIXED
- Fixed NuGet package generation issues.
- Fixed Azure Pipelines credential and authentication issues.
- Fixed multiple pipeline configuration errors to enable automated builds.

### CHANGED
- Renamed `nuget.config` file for consistency.
- Improved pipeline structure and build steps.

### REMOVED
- Removed broken / obsolete pipeline steps during initial setup.
