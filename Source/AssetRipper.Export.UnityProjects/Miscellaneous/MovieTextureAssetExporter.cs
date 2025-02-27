using AssetRipper.Assets;
using AssetRipper.Assets.Collections;
using AssetRipper.Assets.Export;
using AssetRipper.Export.UnityProjects.Project.Exporters;
using AssetRipper.SourceGenerated.Classes.ClassID_152;

namespace AssetRipper.Export.UnityProjects.Miscellaneous
{
	public sealed class MovieTextureAssetExporter : BinaryAssetExporter
	{
		public override bool TryCreateCollection(IUnityObjectBase asset, TemporaryAssetCollection temporaryFile, [NotNullWhen(true)] out IExportCollection? exportCollection)
		{
			if (asset is IMovieTexture texture && IsValidData(texture.MovieData_C152))
			{
				exportCollection = new MovieTextureAssetExportCollection(this, texture);
				return true;
			}
			else
			{
				exportCollection = null;
				return false;
			}
		}

		public override bool Export(IExportContainer container, IUnityObjectBase asset, string path)
		{
			File.WriteAllBytes(path, ((IMovieTexture)asset).MovieData_C152!);
			return true;
		}
	}
}
