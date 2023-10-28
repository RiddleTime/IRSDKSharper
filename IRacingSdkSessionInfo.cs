﻿
#pragma warning disable CS8618

namespace HerboldRacing
{
	public class IRacingSdkSessionInfo
	{
		public CameraInfoModel CameraInfo { get; set; }
		public CarSetupModel CarSetup { get; set; }
		public DriverInfoModel DriverInfo { get; set; }
		public QualifyResultsInfoModel QualifyResultsInfo { get; set; }
		public RadioInfoModel RadioInfo { get; set; }
		public SessionInfoModel SessionInfo { get; set; }
		public SplitTimeInfoModel SplitTimeInfo { get; set; }
		public WeekendInfoModel WeekendInfo { get; set; }

		public class CameraInfoModel
		{
			public List<GroupModel> Groups { get; set; }

			public class GroupModel
			{
				public string GroupName { get; set; }
				public int GroupNum { get; set; }
				public string IsScenic { get; set; }

				public List<CameraModel> Cameras { get; set; }

				public class CameraModel
				{
					public string CameraName { get; set; }
					public int CameraNum { get; set; }
				}
			}
		}

		public class CarSetupModel
		{
			public int UpdateCount { get; set; }

			public ChassisModel Chassis { get; set; }
			public SuspensionModel Suspension { get; set; }
			public TireModel Tires { get; set; }

			public class ChassisModel
			{
				public FrontModel Front { get; set; }
				public FrontArbModel FrontArb { get; set; }
				public LeftFrontModel LeftFront { get; set; }
				public LeftRearModel LeftRear { get; set; }
				public OtherModel Other { get; set; }
				public RearModel Rear { get; set; }
				public RightFrontModel RightFront { get; set; }
				public RightRearModel RightRear { get; set; }

				public class FrontModel
				{
					public int AttachLeftSide { get; set; }
					public string BallastForward { get; set; }
					public string BarPreload { get; set; }
					public string BrakeBalanceBar { get; set; }
					public string CrossWeight { get; set; }
					public string FrontBrakeBias { get; set; }
					public string FrontMc { get; set; }
					public string LeftBarEndClearance { get; set; }
					public string NoseWeight { get; set; }
					public string RearMc { get; set; }
					public string SkirtClearance { get; set; }
					public string SteeringOffset { get; set; }
					public string SteeringPinion { get; set; }
					public string SteeringRatio { get; set; }
					public string SwayBarSize { get; set; }
					public string TapeConfiguration { get; set; }
					public string ToeIn { get; set; }
					public string ValanceClearance { get; set; }
				}

				public class FrontArbModel
				{
					public int Attach { get; set; }
					public string ArbArm { get; set; }
					public string ArbPreload { get; set; }
					public string ArmAsymmetry { get; set; }
					public string ChainOrSolidLink { get; set; }
					public string Diameter { get; set; }
					public string LinkSlack { get; set; }
					public string Preload { get; set; }
				}

				public class LeftFrontModel
				{
					public string BumpStiffness { get; set; }
					public string Camber { get; set; }
					public string Caster { get; set; }
					public string CornerWeight { get; set; }
					public string FrameHeight { get; set; }
					public string HsCompression { get; set; }
					public string HsCompSlope { get; set; }
					public string HsRebound { get; set; }
					public string HsRebSlope { get; set; }
					public string LsCompression { get; set; }
					public string LsRebound { get; set; }
					public string ReboundStiffness { get; set; }
					public string RideHeight { get; set; }
					public string ShockCollarOffset { get; set; }
					public string ShockCompression { get; set; }
					public string ShockDeflection { get; set; }
					public string ShockRebound { get; set; }
					public string SkirtClearance { get; set; }
					public string SpringDeflection { get; set; }
					public string SpringPerch { get; set; }
					public string SpringPerchOffset { get; set; }
					public string SpringRate { get; set; }
					public string ToeIn { get; set; }
				}

				public class LeftRearModel
				{
					public string BumpStiffness { get; set; }
					public string Camber { get; set; }
					public string CornerWeight { get; set; }
					public string FrameHeight { get; set; }
					public string HsCompression { get; set; }
					public string HsCompSlope { get; set; }
					public string HsRebound { get; set; }
					public string HsRebSlope { get; set; }
					public string LeafArchBlock { get; set; }
					public string LeafSpringRate { get; set; }
					public string LeftRearToeIn { get; set; }
					public string LsCompression { get; set; }
					public string LsRebound { get; set; }
					public string ReboundStiffness { get; set; }
					public string RideHeight { get; set; }
					public string ShockCollarOffset { get; set; }
					public string ShockCompression { get; set; }
					public string ShockDeflection { get; set; }
					public string ShockRebound { get; set; }
					public string SkirtClearance { get; set; }
					public string SpringDeflection { get; set; }
					public string SpringPerch { get; set; }
					public string SpringPerchOffset { get; set; }
					public string SpringRate { get; set; }
					public string ToeIn { get; set; }
					public string TrackBarHeight { get; set; }
					public string TruckArmMount { get; set; }
				}

				public class OtherModel
				{
					public string DashDisplayPage { get; set; }
				}

				public class RightFrontModel
				{
					public string BumpStiffness { get; set; }
					public string Camber { get; set; }
					public string Caster { get; set; }
					public string CornerWeight { get; set; }
					public string FrameHeight { get; set; }
					public string HsCompression { get; set; }
					public string HsCompSlope { get; set; }
					public string HsRebound { get; set; }
					public string HsRebSlope { get; set; }
					public string LsCompression { get; set; }
					public string LsRebound { get; set; }
					public string ReboundStiffness { get; set; }
					public string RideHeight { get; set; }
					public string ShockCollarOffset { get; set; }
					public string ShockCompression { get; set; }
					public string ShockDeflection { get; set; }
					public string ShockRebound { get; set; }
					public string SkirtClearance { get; set; }
					public string SpringDeflection { get; set; }
					public string SpringPerch { get; set; }
					public string SpringPerchOffset { get; set; }
					public string SpringRate { get; set; }
					public string ToeIn { get; set; }
				}

				public class RightRearModel
				{
					public string BumpStiffness { get; set; }
					public string Camber { get; set; }
					public string CornerWeight { get; set; }
					public string FrameHeight { get; set; }
					public string HsCompression { get; set; }
					public string HsCompSlope { get; set; }
					public string HsRebound { get; set; }
					public string HsRebSlope { get; set; }
					public string LeafArchBlock { get; set; }
					public string LeafSpringRate { get; set; }
					public string LsCompression { get; set; }
					public string LsRebound { get; set; }
					public string ReboundStiffness { get; set; }
					public string RideHeight { get; set; }
					public string RightRearToeIn { get; set; }
					public string ShockCollarOffset { get; set; }
					public string ShockCompression { get; set; }
					public string ShockDeflection { get; set; }
					public string ShockRebound { get; set; }
					public string SkirtClearance { get; set; }
					public string SpringDeflection { get; set; }
					public string SpringPerch { get; set; }
					public string SpringPerchOffset { get; set; }
					public string SpringRate { get; set; }
					public string ToeIn { get; set; }
					public string TrackBarHeight { get; set; }
					public string TruckArmMount { get; set; }
					public string TruckArmPreload { get; set; }
				}

				public class RearModel
				{
					public string ArbArm { get; set; }
					public float ArbDiameter { get; set; }
					public string ArbPreload { get; set; }
					public string ArmAsymmetry { get; set; }
					public int Attach { get; set; }
					public string ChainOrSolidLink { get; set; }
					public string Diameter { get; set; }
					public string DiffPreload { get; set; }
					public float FinalDriveRatio { get; set; }
					public string FuelFillTo { get; set; }
					public string LinkSlack { get; set; }
					public string Preload { get; set; }
					public float RearEndRatio { get; set; }
					public string SpoilerAngle { get; set; }
				}
			}

			public class SuspensionModel
			{
				public FrontModel Front { get; set; }
				public LeftFrontModel LeftFront { get; set; }
				public LeftRearModel LeftRear { get; set; }
				public RightFrontModel RightFront { get; set; }
				public RightRearModel RightRear { get; set; }
				public RearModel Rear { get; set; }

				public class FrontModel
				{
					public string BrakeBias { get; set; }
				}

				public class LeftFrontModel
				{
					public string Camber { get; set; }
					public string Caster { get; set; }
					public string ColdPressure { get; set; }
					public string CornerWeight { get; set; }
					public string LastHotPressure { get; set; }
					public string LastTempsOMI { get; set; }
					public string TreadRemaining { get; set; }
					public string RideHeight { get; set; }
					public string SpringPerchOffset { get; set; }
				}

				public class LeftRearModel
				{
					public string Camber { get; set; }
					public string ColdPressure { get; set; }
					public string CornerWeight { get; set; }
					public string LastHotPressure { get; set; }
					public string LastTempsOMI { get; set; }
					public string TreadRemaining { get; set; }
					public string RideHeight { get; set; }
				}

				public class RightFrontModel
				{
					public string Camber { get; set; }
					public string Caster { get; set; }
					public string ColdPressure { get; set; }
					public string CornerWeight { get; set; }
					public string LastHotPressure { get; set; }
					public string LastTempsIMO { get; set; }
					public string TreadRemaining { get; set; }
					public string RideHeight { get; set; }
					public string SpringPerchOffset { get; set; }
				}

				public class RightRearModel
				{
					public string Camber { get; set; }
					public string ColdPressure { get; set; }
					public string CornerWeight { get; set; }
					public string LastHotPressure { get; set; }
					public string LastTempsIMO { get; set; }
					public string TreadRemaining { get; set; }
					public string RideHeight { get; set; }
				}

				public class RearModel
				{
					public int AntiRollBar { get; set; }
					public string FuelLevel { get; set; }
				}
			}

			public class TireModel
			{
				public LeftTireModel LeftFront { get; set; }
				public LeftTireModel LeftRear { get; set; }
				public RightTireModel RightFront { get; set; }
				public RightTireModel RightRear { get; set; }

				public class LeftTireModel
				{
					public string ColdPressure { get; set; }
					public string LastHotPressure { get; set; }
					public string LastTempsOMI { get; set; }
					public string TreadRemaining { get; set; }
				}

				public class RightTireModel
				{
					public string ColdPressure { get; set; }
					public string LastHotPressure { get; set; }
					public string LastTempsIMO { get; set; }
					public string Stagger { get; set; }
					public string TreadRemaining { get; set; }
				}
			}
		}

		public class DriverInfoModel
		{
			public int DriverCarEngCylinderCount { get; set; }
			public float DriverCarEstLapTime { get; set; }
			public float DriverCarFuelKgPerLtr { get; set; }
			public float DriverCarFuelMaxLtr { get; set; }
			public int DriverCarGearNeutral { get; set; }
			public int DriverCarGearNumForward { get; set; }
			public int DriverCarGearReverse { get; set; }
			public float DriverCarIdleRPM { get; set; }
			public int DriverCarIdx { get; set; }
			public int DriverCarIsElectric { get; set; }
			public float DriverCarMaxFuelPct { get; set; }
			public float DriverCarRedLine { get; set; }
			public float DriverCarSLBlinkRPM { get; set; }
			public float DriverCarSLFirstRPM { get; set; }
			public float DriverCarSLLastRPM { get; set; }
			public float DriverCarSLShiftRPM { get; set; }
			public string DriverCarVersion { get; set; }
			public float DriverHeadPosX { get; set; }
			public float DriverHeadPosY { get; set; }
			public float DriverHeadPosZ { get; set; }
			public int DriverIncidentCount { get; set; }
			public float DriverPitTrkPct { get; set; } // need to verify
			public int DriverSetupIsModified { get; set; }
			public string DriverSetupLoadTypeName { get; set; }
			public string DriverSetupName { get; set; }
			public int DriverSetupPassedTech { get; set; }
			public int DriverUserID { get; set; }
			public int PaceCarIdx { get; set; }

			public List<DriverModel> Drivers { get; set; }

			public class DriverModel
			{
				public string AbbrevName { get; set; }
				public int BodyType { get; set; }
				public string CarClassColor { get; set; }
				public string CarClassDryTireSetLimit { get; set; }
				public float CarClassEstLapTime { get; set; }
				public int CarClassID { get; set; }
				public int CarClassLicenseLevel { get; set; }
				public string CarClassMaxFuelPct { get; set; }
				public string CarClassPowerAdjust { get; set; }
				public int CarClassRelSpeed { get; set; }
				public string CarClassShortName { get; set; }
				public string CarClassWeightPenalty { get; set; }
				public string CarDesignStr { get; set; }
				public int CarID { get; set; }
				public int CarIdx { get; set; }
				public int CarIsAI { get; set; }
				public int CarIsElectric { get; set; }
				public int CarIsPaceCar { get; set; }
				public string CarNumber { get; set; }
				public string CarNumberDesignStr { get; set; }
				public int CarNumberRaw { get; set; }
				public string CarPath { get; set; }
				public string CarScreenName { get; set; }
				public string CarScreenNameShort { get; set; }
				public int CarSponsor_1 { get; set; }
				public int CarSponsor_2 { get; set; }
				public int ClubID { get; set; } // need to verify
				public string ClubName { get; set; } // need to verify
				public int CurDriverIncidentCount { get; set; }
				public int DivisionID { get; set; } // need to verify
				public string DivisionName { get; set; } // need to verify
				public int FaceType { get; set; }
				public string HelmetDesignStr { get; set; }
				public int HelmetType { get; set; }
				public string Initials { get; set; }
				public int IRating { get; set; }
				public int IsSpectator { get; set; }
				public string LicColor { get; set; }
				public int LicLevel { get; set; }
				public string LicString { get; set; }
				public int LicSubLevel { get; set; }
				public string SuitDesignStr { get; set; }
				public int TeamID { get; set; }
				public int TeamIncidentCount { get; set; }
				public string TeamName { get; set; }
				public int UserID { get; set; }
				public string UserName { get; set; }
			}
		}

		public class QualifyResultsInfoModel
		{
			public List<ResultModel> Results { get; set; }

			public class ResultModel
			{
				public int CarIdx { get; set; }
				public int ClassPosition { get; set; }
				public int FastestLap { get; set; }
				public float FastestTime { get; set; }
				public int Position { get; set; }
			}
		}

		public class RadioInfoModel
		{
			public int SelectedRadioNum { get; set; }

			public List<RadioModel> Radios { get; set; }

			public class RadioModel
			{
				public int HopCount { get; set; }
				public int NumFrequencies { get; set; }
				public int RadioNum { get; set; }
				public int ScanningIsOn { get; set; }
				public int TunedToFrequencyNum { get; set; }

				public List<FrequencyModel> Frequencies { get; set; }

				public class FrequencyModel
				{
					public int CanScan { get; set; }
					public int CanSquawk { get; set; }
					public int CarIdx { get; set; }
					public int ClubID { get; set; }
					public int EntryIdx { get; set; }
					public string FrequencyName { get; set; }
					public int FrequencyNum { get; set; }
					public int IsDeletable { get; set; }
					public int IsMutable { get; set; }
					public int Muted { get; set; }
					public int Priority { get; set; }
				}
			}
		}

		public class SessionInfoModel
		{
			public List<SessionModel> Sessions { get; set; }

			public class SessionModel
			{
				public float ResultsAverageLapTime { get; set; }
				public int ResultsLapsComplete { get; set; }
				public int ResultsNumCautionFlags { get; set; }
				public int ResultsNumCautionLaps { get; set; }
				public int ResultsNumLeadChanges { get; set; }
				public int ResultsOfficial { get; set; }
				public int SessionEnforceTireCompoundChange { get; set; }
				public string SessionLaps { get; set; }
				public string SessionName { get; set; }
				public int SessionNum { get; set; }
				public int SessionNumLapsToAvg { get; set; }
				public int SessionRunGroupsUsed { get; set; }
				public int SessionSkipped { get; set; }
				public string SessionSubType { get; set; }
				public string SessionTime { get; set; }
				public string SessionTrackRubberState { get; set; }
				public string SessionType { get; set; }

				public List<FastestLapModel> ResultsFastestLap { get; set; }
				public List<PositionModel> ResultsPositions { get; set; }

				public class FastestLapModel
				{
					public int CarIdx { get; set; }
					public int FastestLap { get; set; }
					public float FastestTime { get; set; }
				}

				public class PositionModel
				{
					public int CarIdx { get; set; }
					public int ClassPosition { get; set; }
					public int FastestLap { get; set; }
					public float FastestTime { get; set; }
					public int Incidents { get; set; }
					public int JokerLapsComplete { get; set; }
					public int Lap { get; set; }
					public int LapsComplete { get; set; }
					public float LapsDriven { get; set; }
					public int LapsLed { get; set; }
					public float LastTime { get; set; }
					public int Position { get; set; }
					public int ReasonOutId { get; set; }
					public string ReasonOutStr { get; set; }
					public float Time { get; set; }
				}
			}
		}

		public class SplitTimeInfoModel
		{
			public List<SectorModel> Sectors { get; set; }

			public class SectorModel
			{
				public int SectorNum { get; set; }
				public float SectorStartPct { get; set; }
			}
		}

		public class WeekendInfoModel
		{
			public string BuildTarget { get; set; }
			public string BuildType { get; set; }
			public string BuildVersion { get; set; }
			public string Category { get; set; }
			public string DCRuleSet { get; set; }
			public string EventType { get; set; }
			public int HeatRacing { get; set; }
			public int LeagueID { get; set; }
			public int MaxDrivers { get; set; }
			public int MinDrivers { get; set; }
			public int NumCarClasses { get; set; }
			public int NumCarTypes { get; set; }
			public int Official { get; set; }
			public int QualifierMustStartRace { get; set; }
			public int RaceWeek { get; set; }
			public int SeasonID { get; set; }
			public int SeriesID { get; set; }
			public int SessionID { get; set; }
			public string SimMode { get; set; }
			public int SubSessionID { get; set; }
			public int TeamRacing { get; set; }
			public string TrackAirPressure { get; set; }
			public string TrackAirTemp { get; set; }
			public string TrackAltitude { get; set; }
			public string TrackCity { get; set; }
			public int TrackCleanup { get; set; }
			public string TrackConfigName { get; set; }
			public string TrackCountry { get; set; }
			public string TrackDirection { get; set; }
			public string TrackDisplayName { get; set; }
			public string TrackDisplayShortName { get; set; }
			public int TrackDynamicTrack { get; set; }
			public string TrackFogLevel { get; set; }
			public int TrackID { get; set; }
			public string TrackLatitude { get; set; }
			public string TrackLength { get; set; }
			public string TrackLengthOfficial { get; set; }
			public string TrackLongitude { get; set; }
			public string TrackName { get; set; }
			public string TrackNorthOffset { get; set; }
			public int TrackNumTurns { get; set; }
			public string TrackPitSpeedLimit { get; set; }
			public string TrackRelativeHumidity { get; set; }
			public string TrackSkies { get; set; }
			public string TrackSurfaceTemp { get; set; }
			public string TrackType { get; set; }
			public string TrackVersion { get; set; }
			public string TrackWeatherType { get; set; }
			public string TrackWindDir { get; set; }
			public string TrackWindVel { get; set; }

			public TelemetryOptionsModel TelemetryOptions { get; set; }
			public WeekendOptionsModel WeekendOptions { get; set; }

			public class TelemetryOptionsModel
			{
				public string TelemetryDiskFile { get; set; }
			}

			public class WeekendOptionsModel
			{
				public string CommercialMode { get; set; }
				public string CourseCautions { get; set; }
				public string Date { get; set; }
				public float EarthRotationSpeedupFactor { get; set; }
				public int FastRepairsLimit { get; set; }
				public string FogLevel { get; set; }
				public int GreenWhiteCheckeredLimit { get; set; }
				public int HardcoreLevel { get; set; }
				public int HasOpenRegistration { get; set; }
				public string IncidentLimit { get; set; }
				public int IsFixedSetup { get; set; }
				public string NightMode { get; set; }
				public int NumJokerLaps { get; set; }
				public int NumStarters { get; set; }
				public string QualifyScoring { get; set; }
				public string RelativeHumidity { get; set; }
				public string Restarts { get; set; }
				public int ShortParadeLap { get; set; }
				public string Skies { get; set; }
				public int StandingStart { get; set; }
				public string StartingGrid { get; set; }
				public string StrictLapsChecking { get; set; }
				public string TimeOfDay { get; set; }
				public int Unofficial { get; set; }
				public string WeatherTemp { get; set; }
				public string WeatherType { get; set; }
				public string WindDirection { get; set; }
				public string WindSpeed { get; set; }
			}
		}
	}
}

#pragma warning restore CS8618
