
using Exiled.API.Features;
using Exiled.Events.EventArgs.Map;
using Exiled.Events.EventArgs.Scp914;
using LabApi.Events.Arguments.Scp914Events;
using LabApi.Events.Arguments.ServerEvents;
using PlayerRoles;
using Scp914;

namespace AdvancedScp914;

public class UpgradeHandler
{
    public void OnPlayerProcessedInScp914(Scp914ProcessedPlayerEventArgs ev)
    {
        if (ev.KnobSetting == Scp914KnobSetting.Rough)
        {
            switch (ev.Player.Role)
            {
                case RoleTypeId.Scp173:
                {
                    Cassie.MessageTranslated(
                        "SCP 1 7 3 SUCCESSFULLY TERMINATED BY SCPSUBJECT 9 1 4",
                        "SCP-173 успешно уничтожен объектом SCP-914.", true);
                    break;
                }
                case RoleTypeId.Scp106:
                {
                    Cassie.MessageTranslated(
                        "SCP 1 0 6 SUCCESSFULLY TERMINATED BY SCPSUBJECT 9 1 4",
                        "SCP-106 успешно уничтожен объектом SCP-914.", true);
                    break;
                }
                case RoleTypeId.Scp049:
                {
                    Cassie.MessageTranslated(
                        "SCP 0 4 9 SUCCESSFULLY TERMINATED BY SCPSUBJECT 9 1 4",
                        "SCP-049 успешно уничтожен объектом SCP-914.", true);
                    break;
                }
                case RoleTypeId.Scp096:
                {
                    Cassie.MessageTranslated(
                        "SCP 0 9 6 SUCCESSFULLY TERMINATED BY SCPSUBJECT 9 1 4",
                        "SCP-096 успешно уничтожен объектом SCP-914.", true);
                    break;
                }
                case RoleTypeId.Scp939:
                {
                    Cassie.MessageTranslated(
                        "SCP 9 3 9 SUCCESSFULLY TERMINATED BY SCPSUBJECT 9 1 4",
                        "SCP-939 успешно уничтожен объектом SCP-914.", true);
                    break;
                }
                case RoleTypeId.Scp3114:
                {
                    Cassie.MessageTranslated(
                        "SCP 3 1 1 4 SUCCESSFULLY TERMINATED BY SCPSUBJECT 9 1 4",
                        "SCP-3114 успешно уничтожен объектом SCP-914.", true);
                    break;
                }
            }
            ev.Player.Kill("SCP-914");
        }
    }
}