﻿using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.BookStore.BookManagement.EntityFrameworkCore
{
    public class BookManagementModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public BookManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = BookManagementConsts.DefaultDbTablePrefix,
            [CanBeNull] string schema = BookManagementConsts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}