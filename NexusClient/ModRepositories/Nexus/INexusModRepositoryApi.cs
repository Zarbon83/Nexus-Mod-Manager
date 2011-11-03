﻿using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using Nexus.Client.Mods;

namespace Nexus.Client.ModRepositories.Nexus
{
	/// <summary>
	/// Describes the methods and properties of the Nexus mod repository.
	/// </summary>
	/// <remarks>
	/// The Nexus mod repository is the repository hosted with the Nexus group of websites.
	/// </remarks>
	[ServiceContract]
	public interface INexusModRepositoryApi
	{
		/// <summary>
		/// Gets the info about the specified mod from the repository.
		/// </summary>
		/// <param name="p_strModId">The id of the mod for which to retrieved the metadata.</param>
		/// <returns>The info about the specified mod from the repository.</returns>
		[OperationContract]
		[WebGet(
			BodyStyle = WebMessageBodyStyle.Bare,
			UriTemplate = "Mods/{p_strModId}/",
			ResponseFormat = WebMessageFormat.Json)]
		NexusModInfo GetModInfo(string p_strModId);

		/// <summary>
		/// Gets the files associated with the specified mod from the repository.
		/// </summary>
		/// <param name="p_strModId">The id of the mod for which to retrieved the associated files.</param>
		/// <returns>The files associated with the specified mod from the repository.</returns>
		[OperationContract]
		[WebGet(
			BodyStyle = WebMessageBodyStyle.Bare,
			UriTemplate = "Mods/{p_strModId}/Files/",
			ResponseFormat = WebMessageFormat.Json)]
		List<NexusModFileInfo> GetModFiles(string p_strModId);

		/// <summary>
		/// Gets the file info for the specified download file of the specified mod.
		/// </summary>
		/// <param name="p_strModId">The id of the mod the whose file's metadata is to be retrieved.</param>
		/// <param name="p_strFileId">The id of the download file whose metadata is to be retrieved.</param>
		/// <returns>The file info for the specified download file of the specified mod.</returns>
		[OperationContract]
		[WebGet(
			BodyStyle = WebMessageBodyStyle.Bare,
			UriTemplate = "Mods/{p_strModId}/Files/{p_strFileId}/",
			ResponseFormat = WebMessageFormat.Json)]
		NexusModFileInfo GetModFile(string p_strModId, string p_strFileId);

		/// <summary>
		/// Gets the download URLs of all the parts associated with the specified file.
		/// </summary>
		/// <param name="p_strModId">The id of the mod with which the file for which to retrieve the URLs is associated.</param>
		/// <param name="p_strFileId">The id of the file for which to retrieve the URLs.</param>
		/// <returns>The download URLs of all the parts associated with the specified file.</returns>
		[OperationContract]
		[WebGet(
			BodyStyle = WebMessageBodyStyle.Bare,
			UriTemplate = "Mods/{p_strModId}/Files/{p_strFileId}/DownloadTest/",
			ResponseFormat = WebMessageFormat.Json)]
		string GetModFileDownloadUrls(string p_strModId, string p_strFileId);

		/// <summary>
		/// Finds the mods containing the given search terms.
		/// </summary>
		/// <param name="p_strModNameSearchString">The terms to use to search for mods.</param>
		/// <param name="p_strType">Whether the returned mods' names should include all of
		/// the given search terms, or any of the terms.</param>
		/// <returns>The mod info for the mods matching the given search criteria.</returns>
		[OperationContract]
		[WebGet(
			BodyStyle = WebMessageBodyStyle.Bare,
			UriTemplate = "Mods/?Find&name={p_strModNameSearchString}&type={p_strType}",
			ResponseFormat = WebMessageFormat.Json)]
		List<NexusModInfo> FindMods(string p_strModNameSearchString, string p_strType);
	}
}