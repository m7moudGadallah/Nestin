using Nestin.Core.Entities;

namespace Nestin.Infrastructure.Data.Seeds
{
    static class FileUploadSeed
    {
        public static List<FileUpload> Data => new()
        {
            new FileUpload { Id = "b455bb0a-69a3-4024-b5fa-5a49323e58fd", Path = "images/egy1.avif" },
            new FileUpload { Id = "dc16e3d2-16ed-4ff5-b9c2-27a1e8b5ccbe", Path = "images/egy2.avif" },
            new FileUpload { Id = "4b0f81f1-9bc0-45c6-988e-1a4fd270b3e0", Path = "images/egy3.avif" },
            new FileUpload { Id = "2ac68b52-e7b6-4bb7-9f8e-49aa7f2b2b6c", Path = "images/italy1.webp" },
            new FileUpload { Id = "69c6c01e-65b3-4cf7-bbc7-2e94272b658a", Path = "images/italy2.avif" },
            new FileUpload { Id = "95cde2b1-305e-4c13-9293-8c4c8f7c8b9f", Path = "images/italy3.avif" },
            new FileUpload { Id = "7a18064f-b6cb-4d58-a51b-0e8a74eac7a4", Path = "images/makkah1.avif" },
            new FileUpload { Id = "4dfe3d56-2d34-4a6b-9cb5-f7a5a2dd8c28", Path = "images/makkah2.avif" },
            new FileUpload { Id = "6c54a231-b88f-409f-b5d5-170180930186", Path = "images/makkah3.avif" },
            new FileUpload { Id = "26d418bb-0f90-4f3c-b339-7dd5c31b5e99", Path = "images/california1.jpeg" },
            new FileUpload { Id = "a4c0d40d-e90e-4b14-8a2a-5ac0212be9b1", Path = "images/california2.jpeg" },
            new FileUpload { Id = "89f65612-5023-489e-9604-2f01074abf0c", Path = "images/california3.avif" },
            new FileUpload { Id = "b21f8f4f-6d95-4f60-81b4-56d2ef017a08", Path = "images/brazil1.avif" },
            new FileUpload { Id = "e34a2808-38df-4e47-8c3e-d6e3f2712f11", Path = "images/brazil2.avif" },
            new FileUpload { Id = "5b742ed2-28d9-4e3b-8125-6e9c4587a0d3", Path = "images/brazil3.avif" },
            new FileUpload { Id = "2cf95d6d-63ae-4b97-8101-c6c5e8227b6d", Path = "images/barcelona1.avif" },
            new FileUpload { Id = "ce9e31d6-6553-4214-8b94-fb9c8f3065ed", Path = "images/barcelona2.avif" },
            new FileUpload { Id = "5e2e82a1-4893-4a63-9375-d73f7a09d7c5", Path = "images/barcelona3.avif" },
            new FileUpload { Id = "7d861c0c-011d-4b2a-8ce5-f5b1f0b81d01", Path = "images/jordan1.avif" },
            new FileUpload { Id = "fbc177de-bf4c-4b75-a1f6-884d05ce6c9f", Path = "images/jordan2.avif" },
            new FileUpload { Id = "51d1e109-dccf-45fd-9f15-bbd3c0b7fcd5", Path = "images/jordan3.avif" },
            new FileUpload { Id = "6c79893d-f97f-4fc6-b0c3-4ebfcab3f85f", Path = "images/france1.avif" },
            new FileUpload { Id = "98a76538-918f-4e60-9c01-b364e0e1891f", Path = "images/france2.avif" },
            new FileUpload { Id = "f3885b77-0f9e-4ec3-9b3e-cbc194a07d7f", Path = "images/france3.avif" }
        };
    }
}