using CovidTracking.Api.Enums;
using CovidTracking.Api.Models.V1;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CovidTracking.Api.V1
{
	/// <summary>
	/// Covid Tracking Request Service
	/// </summary>
	public interface ICovidTrackingRequest
	{
		/// <summary>
		/// The most recent COVID data for every state. The current value may be different than today.
		/// </summary>
		/// <returns></returns>
		Task<IEnumerable<State>> GetAllStateCurrent();

		/// <summary>
		/// Lists all COVID data available for every state since tracking started.
		/// </summary>
		/// <returns></returns>
		Task<IEnumerable<State>> GetAllStateHistoric();

		/// <summary>
		/// Basic information about states, including notes about our methodology and the websites we use to check for data.
		/// </summary>
		/// <returns></returns>
		Task<IEnumerable<StateMetadata>> GetAllStateMetadata();

		/// <summary>
		/// Get Covid Tracking Api status.
		/// </summary>
		/// <returns></returns>
		Task<ApiStatus> GetApiStatus();

		/// <summary>
		/// The most recent COVID data for the US. The most recent data may not be from today.
		/// </summary>
		/// <returns></returns>
		Task<Country> GetCountryCurrentDaily();

		/// <summary>
		/// All COVID data for the US on a specific date.
		/// </summary>
		/// <param name="date"></param>
		/// <returns></returns>
		Task<Country> GetCountryHistoricByDay(DateTime date);

		/// <summary>
		/// All COVID data for the US.
		/// </summary>
		/// <returns></returns>
		Task<IEnumerable<Country>> GetCountryHistoric();

		/// <summary>
		/// The most recent COVID data for a single state. The current value may be different than today.
		/// </summary>
		/// <param name="usState"></param>
		/// <returns></returns>
		Task<State> GetStateCurrent(UsState usState);

		/// <summary>
		/// All COVID data for a single state.
		/// </summary>
		/// <param name="usState"></param>
		/// <returns></returns>
		Task<IEnumerable<State>> GetStateHistoric(UsState usState);

		/// <summary>
		/// All COVID values for a single state on a specific date.
		/// </summary>
		/// <param name="usState"></param>
		/// <param name="date"></param>
		/// <returns></returns>
		Task<State> GetStateHistoricByDate(UsState usState, DateTime date);

		/// <summary>
		/// Metadata about a specific state
		/// </summary>
		/// <param name="usState"></param>
		/// <returns></returns>
		Task<StateMetadata> GetStateMetadata(UsState usState);
	}
}
