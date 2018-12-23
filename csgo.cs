using System;

// 2018-12-23 11:04:46.761803 UTC

namespace hazedumper
{
    public static class netvars
    {
        public const Int32 m_ArmorValue = 0xB328;
        public const Int32 m_Collision = 0x31C;
        public const Int32 m_CollisionGroup = 0x474;
        public const Int32 m_Local = 0x2FBC;
        public const Int32 m_MoveType = 0x25C;
        public const Int32 m_OriginalOwnerXuidHigh = 0x31B4;
        public const Int32 m_OriginalOwnerXuidLow = 0x31B0;
        public const Int32 m_aimPunchAngle = 0x302C;
        public const Int32 m_aimPunchAngleVel = 0x3038;
        public const Int32 m_bGunGameImmunity = 0x3928;
        public const Int32 m_bHasDefuser = 0xB338;
        public const Int32 m_bHasHelmet = 0xB31C;
        public const Int32 m_bInReload = 0x3285;
        public const Int32 m_bIsDefusing = 0x3914;
        public const Int32 m_bIsScoped = 0x390A;
        public const Int32 m_bSpotted = 0x93D;
        public const Int32 m_bSpottedByMask = 0x980;
        public const Int32 m_clrRender = 0x70;
        public const Int32 m_dwBoneMatrix = 0x26A8;
        public const Int32 m_fAccuracyPenalty = 0x3304;
        public const Int32 m_fFlags = 0x104;
        public const Int32 m_flFallbackWear = 0x31C0;
        public const Int32 m_flFlashDuration = 0xA3E0;
        public const Int32 m_flFlashMaxAlpha = 0xA3DC;
        public const Int32 m_flNextPrimaryAttack = 0x3218;
        public const Int32 m_hActiveWeapon = 0x2EF8;
        public const Int32 m_hMyWeapons = 0x2DF8;
        public const Int32 m_hObserverTarget = 0x3388;
        public const Int32 m_hOwner = 0x29CC;
        public const Int32 m_hOwnerEntity = 0x14C;
        public const Int32 m_iAccountID = 0x2FC8;
        public const Int32 m_iClip1 = 0x3244;
        public const Int32 m_iCompetitiveRanking = 0x1A84;
        public const Int32 m_iCompetitiveWins = 0x1B88;
        public const Int32 m_iCrosshairId = 0xB394;
        public const Int32 m_iEntityQuality = 0x2FAC;
        public const Int32 m_iFOVStart = 0x31E8;
        public const Int32 m_iGlowIndex = 0xA3F8;
        public const Int32 m_iHealth = 0x100;
        public const Int32 m_iItemDefinitionIndex = 0x2FAA;
        public const Int32 m_iItemIDHigh = 0x2FC0;
        public const Int32 m_iObserverMode = 0x3374;
        public const Int32 m_iShotsFired = 0xA370;
        public const Int32 m_iState = 0x3238;
        public const Int32 m_iTeamNum = 0xF4;
        public const Int32 m_lifeState = 0x25F;
        public const Int32 m_nFallbackPaintKit = 0x31B8;
        public const Int32 m_nFallbackSeed = 0x31BC;
        public const Int32 m_nFallbackStatTrak = 0x31C4;
        public const Int32 m_nForceBone = 0x268C;
        public const Int32 m_nTickBase = 0x342C;
        public const Int32 m_rgflCoordinateFrame = 0x444;
        public const Int32 m_szCustomName = 0x303C;
        public const Int32 m_szLastPlaceName = 0x35B0;
        public const Int32 m_thirdPersonViewAngles = 0x31D8;
        public const Int32 m_vecOrigin = 0x138;
        public const Int32 m_vecVelocity = 0x114;
        public const Int32 m_vecViewOffset = 0x108;
        public const Int32 m_viewPunchAngle = 0x3020;
    }
    public static class signatures
    {
        public const Int32 dwClientState = 0x58BCFC;
        public const Int32 dwClientState_GetLocalPlayer = 0x180;
        public const Int32 dwClientState_IsHLTV = 0x4CC8;
        public const Int32 dwClientState_Map = 0x28C;
        public const Int32 dwClientState_MapDirectory = 0x188;
        public const Int32 dwClientState_MaxPlayer = 0x310;
        public const Int32 dwClientState_PlayerInfo = 0x5240;
        public const Int32 dwClientState_State = 0x108;
        public const Int32 dwClientState_ViewAngles = 0x4D10;
        public const Int32 dwEntityList = 0x4CCDBFC;
        public const Int32 dwForceAttack = 0x30FF2A0;
        public const Int32 dwForceAttack2 = 0x30FF2AC;
        public const Int32 dwForceBackward = 0x30FF2E8;
        public const Int32 dwForceForward = 0x30FF2F4;
        public const Int32 dwForceJump = 0x5170DB0;
        public const Int32 dwForceLeft = 0x30FF30C;
        public const Int32 dwForceRight = 0x30FF300;
        public const Int32 dwGameDir = 0x631E70;
        public const Int32 dwGameRulesProxy = 0x51E30E4;
        public const Int32 dwGetAllClasses = 0xCE1964;
        public const Int32 dwGlobalVars = 0x58BA00;
        public const Int32 dwGlowObjectManager = 0x520DA28;
        public const Int32 dwInput = 0x5118990;
        public const Int32 dwInterfaceLinkList = 0x89E254;
        public const Int32 dwLocalPlayer = 0xCBD3F4;
        public const Int32 dwMouseEnable = 0xCC3200;
        public const Int32 dwMouseEnablePtr = 0xCC31D0;
        public const Int32 dwPlayerResource = 0x30FD65C;
        public const Int32 dwRadarBase = 0x510293C;
        public const Int32 dwSensitivity = 0xCC309C;
        public const Int32 dwSensitivityPtr = 0xCC3070;
        public const Int32 dwSetClanTag = 0x895C0;
        public const Int32 dwViewMatrix = 0x4CBF614;
        public const Int32 dwWeaponTable = 0x5119454;
        public const Int32 dwWeaponTableIndex = 0x323C;
        public const Int32 dwYawPtr = 0xCC2E60;
        public const Int32 dwZoomSensitivityRatioPtr = 0xCC80A0;
        public const Int32 dwbSendPackets = 0xD210A;
        public const Int32 dwppDirect3DDevice9 = 0xA3FC0;
        public const Int32 m_pStudioHdr = 0x294C;
        public const Int32 m_pitchClassPtr = 0x5102BF0;
        public const Int32 m_yawClassPtr = 0xCC2E60;
    }
} // namespace hazedumper
