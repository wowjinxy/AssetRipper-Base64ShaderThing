using AssetRipper.Export.Modules.Shaders.IO;
using AssetRipper.Export.Modules.Shaders.ShaderBlob;
using AssetRipper.SourceGenerated.Extensions.Enums.Shader;

namespace AssetRipper.Export.Modules.Shaders.Exporters
{
	public class ShaderUnknownExporter : ShaderTextExporter
	{
		public override string Name => "ShaderUnknownExporter";

		public ShaderUnknownExporter(GPUPlatform graphicApi)
		{
			m_graphicApi = graphicApi;
		}

		public override void Export(ShaderWriter writer, ref ShaderSubProgram subProgram)
		{
			var b64 = Convert.ToBase64String(subProgram.ProgramData);
			
			writer.Write("/*ShaderUnknownExporter : Can't export program data {0} as a text\n" +
			"b64:\n" + b64 +
			"\n*/", m_graphicApi);
		}

		private readonly GPUPlatform m_graphicApi;
	}
}
