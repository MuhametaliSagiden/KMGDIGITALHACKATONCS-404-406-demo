using IdentityRiskAnalyzer.Web.Domain.Enums;

namespace IdentityRiskAnalyzer.Web.ViewModels;

/// <summary>Russian labels used by the first-party web interface.</summary>
public static class UiText
{
    private sealed record FindingText(string Title, string Description, string Recommendation);

    private static readonly IReadOnlyDictionary<string, FindingText> Findings = new Dictionary<string, FindingText>(StringComparer.OrdinalIgnoreCase)
    {
        ["IRA-ACCOUNT-001"] = new("Активная учётная запись не использовалась", "У активной учётной записи не обнаружена реплицированная активность за заданный период.", "Уточните у владельца, используется ли учётная запись. Если она больше не нужна, рассмотрите её отключение по внутренней процедуре."),
        ["IRA-ACCOUNT-002"] = new("Срок действия учётной записи истёк", "Дата окончания срока действия учётной записи уже прошла.", "Проверьте, нужна ли эта учётная запись и правильно ли задан срок её действия."),
        ["IRA-ACCOUNT-003"] = new("Учётная запись заблокирована", "Вычисленные флаги Active Directory указывают на текущую блокировку учётной записи.", "Установите причину блокировки и примените процедуру разблокировки после подтверждения владельца учётной записи."),
        ["IRA-PASSWORD-001"] = new("Срок действия пароля не ограничен", "У учётной записи установлен флаг DONT_EXPIRE_PASSWORD.", "Проверьте, обосновано ли исключение из политики смены пароля, и примените утверждённые требования к учётным данным."),
        ["IRA-PASSWORD-002"] = new("Пароль давно не менялся", "Дата последней установки пароля достигла или превысила настроенный порог срока действия пароля.", "Проверьте дату последней смены пароля и примените действующую политику с учётом типа учётной записи."),
        ["IRA-SERVICE-001"] = new("Пароль сервисной учётной записи не истекает", "Для классифицированной сервисной учётной записи настроен пароль без срока действия.", "Уточните владельца и способ управления учётной записью, затем проверьте возможность безопасной ротации секрета."),
        ["IRA-PRIV-001"] = new("Прямое членство в привилегированной группе", "Учётная запись напрямую включена в настроенную привилегированную группу.", "Проверьте необходимость прямого членства и сохраните его только при подтверждённой рабочей необходимости."),
        ["IRA-PRIV-002"] = new("Вложенное членство в привилегированной группе", "Учётная запись получает членство в настроенной привилегированной группе через вложенную группу.", "Проверьте всю цепочку вложенного членства. Убедитесь, что полномочия действительно нужны, и удалите лишние назначения после согласования."),
        ["IRA-PRIV-003"] = new("Членство в нескольких привилегированных группах", "У учётной записи есть отдельные цепочки членства в двух или более настроенных привилегированных группах.", "Проверьте сочетание административных ролей и подтвердите необходимость каждой роли с владельцами систем."),
        ["IRA-PRIV-004"] = new("Привилегированная учётная запись не использовалась", "У активной привилегированной учётной записи не обнаружена реплицированная активность за более строгий заданный период.", "Подтвердите у владельца необходимость привилегированной учётной записи. Если она больше не нужна, рассмотрите её отключение по внутренней процедуре."),
        ["IRA-DELEGATION-001"] = new("Настроено неограниченное делегирование Kerberos", "Для учётной записи настроено неограниченное делегирование Kerberos; конфигурацию необходимо проверить.", "Проверьте необходимость неограниченного делегирования и после оценки зависимостей рассмотрите более ограниченную конфигурацию."),
        ["IRA-DELEGATION-002"] = new("Настроено ограниченное делегирование Kerberos", "Для учётной записи заданы целевые службы делегирования, которые требуют проверки.", "Проверьте каждую целевую службу и подтвердите, что делегирование ограничено необходимыми службами и их владельцами."),
        ["IRA-DELEGATION-003"] = new("Настроен переход протокола Kerberos", "Включён переход протокола с целевыми службами ограниченного делегирования; конфигурацию необходимо проверить.", "Проверьте необходимость перехода протокола и обоснованность каждой разрешённой целевой службы."),
        ["IRA-DELEGATION-004"] = new("Настроено делегирование с ограничением на стороне ресурса", "Настроено Resource-Based Constrained Delegation. ACL дескриптора безопасности в этой версии не анализируется.", "Отдельно проверьте ACL Resource-Based Constrained Delegation и убедитесь, что делегирование разрешено только необходимым субъектам."),
        ["IRA-AD-001"] = new("Указаны значения SIDHistory", "У учётной записи есть значения SIDHistory, требующие проверки. Само их наличие не доказывает злоупотребление.", "Проверьте происхождение SIDHistory и необходимость его сохранения. Убедитесь, что значения связаны с легитимной миграцией и не дают неожиданных полномочий."),
        ["IRA-SPN-001"] = new("Имя службы SPN назначено нескольким объектам", "Одинаковое имя Service Principal Name обнаружено у нескольких объектов каталога.", "Проверьте владельцев объектов и пользователей SPN, затем устраните дублирование по процедуре управления Active Directory."),
        ["IRA-AUTH-001"] = new("Возможна password spraying-атака", "За короткий период с одного источника зафиксированы неудачные попытки входа с несколькими именами учётных записей.", "Проверьте события входа и источник активности, подтвердите, ожидаема ли она, и проверьте меры защиты учётных записей."),
        ["IRA-AUTH-002"] = new("Возможен подбор пароля", "За короткий период для этой учётной записи зафиксированы повторные неудачные попытки входа.", "Проверьте события входа и источник активности, подтвердите, ожидаема ли она, и проверьте меры защиты учётной записи.")
    };

    private static readonly IReadOnlyDictionary<string, string> Labels = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        ["Account"] = "Учётные записи", ["Password"] = "Пароли", ["ServiceAccount"] = "Сервисные учётные записи",
        ["Privilege"] = "Привилегии", ["Delegation"] = "Делегирование", ["ActiveDirectory"] = "Active Directory",
        ["SPN"] = "SPN", ["Authentication"] = "Аутентификация", ["Critical"] = "Критический",
        ["High"] = "Высокий", ["Medium"] = "Средний", ["Low"] = "Низкий", ["Unknown"] = "Неизвестно",
        ["Yes"] = "Да", ["No"] = "Нет", ["Possible"] = "Вероятно", ["Direct"] = "Прямое",
        ["Nested"] = "Вложенное", ["Pending"] = "Ожидает", ["Running"] = "Выполняется",
        ["Completed"] = "Завершено", ["CompletedWithErrors"] = "Завершено с ошибками",
        ["Failed"] = "Ошибка", ["Cancelled"] = "Отменено", ["None"] = "Нет",
        ["Security"] = "Безопасности", ["Distribution"] = "Рассылки", ["Builtin Local"] = "Локальная встроенная",
        ["Global"] = "Глобальная", ["Domain Local"] = "Локальная домена", ["Universal"] = "Универсальная",
        ["Unknown scope"] = "Область неизвестна", ["Definitive"] = "Точная", ["Heuristic"] = "Эвристическая",
        ["Service Principal Name"] = "Имя субъекта-службы (SPN)",
        ["Managed Service Account (MSA)"] = "Управляемая сервисная учётная запись (MSA)",
        ["Group Managed Service Account (gMSA)"] = "Групповая управляемая сервисная учётная запись (gMSA)",
        ["Name heuristic"] = "Эвристика по имени", ["Multiple signals"] = "Несколько признаков",
        ["Unconstrained"] = "Неограниченное делегирование", ["Constrained"] = "Ограниченное делегирование",
        ["Protocol Transition"] = "Переход протокола", ["Resource-Based Constrained Delegation"] = "Делегирование с ограничением на стороне ресурса",
        ["Sid"] = "По SID", ["Rid"] = "По RID", ["ConfiguredName"] = "По настроенному имени"
    };

    public static string Severity(RiskSeverity value) => value switch
    {
        RiskSeverity.Critical => "Критический",
        RiskSeverity.High => "Высокий",
        RiskSeverity.Medium => "Средний",
        _ => "Низкий"
    };

    public static string ScanStatus(ScanStatus value) => value switch
    {
        IdentityRiskAnalyzer.Web.Domain.Enums.ScanStatus.Pending => "Ожидает",
        IdentityRiskAnalyzer.Web.Domain.Enums.ScanStatus.Running => "Выполняется",
        IdentityRiskAnalyzer.Web.Domain.Enums.ScanStatus.Completed => "Завершено",
        IdentityRiskAnalyzer.Web.Domain.Enums.ScanStatus.CompletedWithErrors => "Завершено с ошибками",
        IdentityRiskAnalyzer.Web.Domain.Enums.ScanStatus.Failed => "Ошибка",
        IdentityRiskAnalyzer.Web.Domain.Enums.ScanStatus.Cancelled => "Отменено",
        _ => value.ToString()
    };

    public static string ScanStatus(ScanStatus? value) => value.HasValue ? ScanStatus(value.Value) : "—";

    public static string Category(string? value) => Translate(value);
    public static string Translate(string? value) => value is not null && Labels.TryGetValue(value, out var translated) ? translated : value ?? "—";
    public static string GroupType(string? value) => value is null ? "—" : value
        .Replace("Security", "Группа безопасности", StringComparison.Ordinal)
        .Replace("Distribution", "Группа рассылки", StringComparison.Ordinal)
        .Replace("Builtin Local", "встроенная локальная", StringComparison.Ordinal)
        .Replace("Domain Local", "локальная домена", StringComparison.Ordinal)
        .Replace("Global", "глобальная", StringComparison.Ordinal)
        .Replace("Universal", "универсальная", StringComparison.Ordinal)
        .Replace("Unknown scope", "область неизвестна", StringComparison.Ordinal);
    public static string ObjectType(AdObjectType value) => value switch
    {
        AdObjectType.User => "Пользователь",
        AdObjectType.Group => "Группа",
        AdObjectType.Computer => "Компьютер",
        AdObjectType.ServiceAccount => "Сервисная учётная запись",
        _ => "Неизвестно"
    };
    public static string ServiceAccountStatus(string value) => Translate(value);
    public static string DetectionMethod(string value) => Translate(value);
    public static string Confidence(string value) => value switch
    {
        "Definitive" => "Подтверждённая",
        "High" => "Высокая",
        "Heuristic" => "Средняя (по косвенным признакам)",
        _ => "Нет"
    };

    public static string FindingTitle(string ruleId, string? fallback) => Findings.TryGetValue(ruleId, out var text) ? text.Title : fallback ?? "";
    public static string FindingDescription(string ruleId, string? fallback) => Findings.TryGetValue(ruleId, out var text) ? text.Description : fallback ?? "";
    public static string FindingRecommendation(string ruleId, string? fallback) => Findings.TryGetValue(ruleId, out var text) ? text.Recommendation : fallback ?? "";

    public static string Evidence(string? value)
    {
        if (string.IsNullOrEmpty(value)) return value ?? "Доказательства не сохранены.";
        return value
            .Replace("Last known activity:", "Последняя известная активность:", StringComparison.Ordinal)
            .Replace("current date:", "текущая дата:", StringComparison.Ordinal)
            .Replace("inactive period:", "период неактивности:", StringComparison.Ordinal)
            .Replace("configured threshold:", "настроенный порог:", StringComparison.Ordinal)
            .Replace("days", "дн.", StringComparison.Ordinal)
            .Replace("SIDHistory count:", "Количество SIDHistory:", StringComparison.Ordinal)
            .Replace("values shown:", "показано значений:", StringComparison.Ordinal)
            .Replace("Additional values omitted:", "Не показано дополнительных значений:", StringComparison.Ordinal)
            .Replace("Duplicate SPN:", "Дублирующийся SPN:", StringComparison.Ordinal)
            .Replace("Also assigned to:", "Также назначен объектам:", StringComparison.Ordinal)
            .Replace("Object class includes", "Класс объекта содержит", StringComparison.Ordinal)
            .Replace("Account has", "У учётной записи", StringComparison.Ordinal)
            .Replace("Service Principal Name(s).", "имён субъектов-служб (SPN).", StringComparison.Ordinal)
            .Replace("Account name matches configured pattern:", "Имя учётной записи соответствует настроенному шаблону:", StringComparison.Ordinal)
            .Replace("Service account classification is heuristic and should be confirmed.", "Классификация сервисной учётной записи основана на эвристике и требует подтверждения.", StringComparison.Ordinal)
            .Replace("Password setting: userAccountControl contains DONT_EXPIRE_PASSWORD.", "Настройка пароля: userAccountControl содержит DONT_EXPIRE_PASSWORD.", StringComparison.Ordinal);
    }

    public static string Message(string? value) => value switch
    {
        "No service-account indicators were found." => "Признаки сервисной учётной записи не обнаружены.",
        "Not evaluated in this MVP." => "В этой версии не проверяется.",
        "Not applicable" => "Не применимо",
        "Not available" => "Нет данных",
        "LDAPS bind and Base DN query succeeded." => "Подключение LDAPS установлено, базовый DN доступен.",
        "LDAP bind and Base DN query succeeded." => "Подключение LDAP установлено, базовый DN доступен.",
        "Configured Base DN could not be queried." => "Не удалось выполнить запрос к настроенному базовому DN.",
        "Active Directory configuration is invalid." => "Конфигурация Active Directory содержит ошибки.",
        "LDAPS server is unavailable or a TLS connection could not be established." => "Сервер LDAPS недоступен или не удалось установить TLS-соединение.",
        "LDAP server is unavailable." => "Сервер LDAP недоступен.",
        "LDAP connection timed out." => "Истекло время ожидания ответа LDAP-сервера.",
        "LDAP authentication failed." => "Не удалось пройти аутентификацию LDAP.",
        "LDAPS/TLS connection failed. Check the server certificate and client trust." => "Не удалось установить LDAPS/TLS-соединение. Проверьте сертификат сервера и доверие к нему.",
        "LDAP protocol error occurred." => "Произошла ошибка протокола LDAP.",
        "LDAP connection test failed." => "Не удалось проверить подключение LDAP.",
        "The scan could not be saved to the database." => "Не удалось сохранить сканирование в базе данных.",
        "Active Directory collection failed. Check the connection and directory settings." => "Не удалось получить данные Active Directory. Проверьте подключение и настройки каталога.",
        "The scan could not complete its analysis." => "Не удалось завершить анализ сканирования.",
        "The scan did not start." => "Сканирование не запустилось.",
        "A scan is already running in this application instance." => "В этом экземпляре приложения уже выполняется сканирование.",
        "Could not retrieve users from Active Directory. Check the connection settings and try again." => "Не удалось получить пользователей из Active Directory. Проверьте настройки подключения и повторите попытку.",
        "Could not retrieve groups from Active Directory. Check the connection settings and try again." => "Не удалось получить группы из Active Directory. Проверьте настройки подключения и повторите попытку.",
        "Could not analyze group membership from Active Directory. Check the connection settings and try again." => "Не удалось проанализировать членство в группах Active Directory. Проверьте настройки подключения и повторите попытку.",
        "Windows Security Event Log is unavailable on this platform." => "Журнал безопасности Windows недоступен на этой платформе.",
        "Security Event Log is unavailable or access was denied." => "Журнал безопасности недоступен или в доступе отказано.",
        _ => value ?? ""
    };
}
