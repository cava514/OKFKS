using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Text;

namespace WinFormsAppNamedPipeServerStream
{
    public class ScriptingHost
    {
        private ScriptOptions scriptOptions = ScriptOptions
            .Default
            .WithReferences(AppDomain.CurrentDomain.GetAssemblies())
            .WithImports(
            "System",
            "System.Collections.Generic",
            "System.Linq");

        public async Task ExecuteAsync(string? code)
        {
            await CSharpScript.EvaluateAsync(code, scriptOptions, new Automation());
        }

        public async Task Run()
        {
            while (true)
            {
                using (NamedPipeServerStream server = new NamedPipeServerStream("mypipe", PipeDirection.In))
                {
                    server.WaitForConnection();
                    await HandleClient(server);
                }
            }
        }

        public async Task HandleClient(NamedPipeServerStream server)
        {
            StreamReader streamReader = new(server);
            await ExecuteAsync(await streamReader.ReadLineAsync());
        }
    }
}
