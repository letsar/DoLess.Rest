﻿using System;
using System.Threading.Tasks;
using DoLess.Rest.Sample;
using DoLess.Rest.Sample.ConstantsNamespace;


// This file is generated by DoLess.Rest.
// All modifications will be erased at the next build.
// Please modify the dependent interface in order to change this file.
namespace DoLess.Rest.Generated
{
    internal sealed class RestClientForIRestApi01 : RestClientBase, IRestApi01
    {
        public Task<string> GetBook(string id)
        {
            return RestRequest.Get(this)
                              .WithUriTemplatePrefix(Constants.BaseApi)
                              .WithUriTemplate("/v1/app/books/{id}")
                              .WithUriVariable("id", id)
                              .ReadAsStringAsync();
        }

        public Task<string> GetBook2(string id)
        {
            return RestRequest.Get(this)
                              .WithUriTemplatePrefix(Constants.BaseApi)
                              .WithUriTemplate("/v1/app/books/{id}")
                              .WithUriVariable("id", id)
                              .ReadAsStringAsync();
        }
    }
}